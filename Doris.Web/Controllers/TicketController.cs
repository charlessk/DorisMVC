using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Doris.Domain;
using Doris.Web.Models;
namespace Doris.Web.Controllers
{
    //[Authorize]
    public class TicketController : Controller
    {
        private readonly IDorisDataSource _db;
       
        public TicketController(IDorisDataSource db)
        {
            _db = db;
        }

        private Ticket ChangeTicketLocked(int id = 0)
        {
            var model = _db.Query<Ticket>().Single(t=>t.TicketId == id);
            //Boolean lock and unlock the ticket, opposite of current value
            model.Locked = !model.Locked;
            _db.SaveChanges();
            return model;
        }

        private IQueryable<MessageView> GetMessageModel(int id)
        {
            var model = _db.Query<Message>()
                            .Where(t => t.TicketId == id)
                            .Join(_db.Tickets, a => a.TicketId, b => b.TicketId,
                             (a, b) => new { Message = a, Ticket = b })
                            .Select(t => new MessageView
                            {
                                MessageId = t.Message.MessageId,
                                Body = t.Message.Body,
                                From = t.Message.From,
                                To = t.Message.To,
                                Cc = t.Message.BCc,
                                Subject = t.Message.Subject,
                                TicketId = id,
                                Locked = t.Ticket.Locked,
                                LockBttn = t.Ticket.Locked == true ? "Unlock" : "Lock"
                                
                            });
             return model;
        }

        private IQueryable<TicketViewModel> GetTicketModel()
        {
            var model = _db.Query<Ticket>()
                           .Select(t => new TicketViewModel
                               {
                                   TicketId =  t.TicketId,
                                   Name = t.Name,
                                   Text = t.Text,
                                   CreateDate = t.CreateDate,
                                   Locked = t.Locked,
                                   TicketPriorityId = t.TicketPriorityId
                               });
            return model;
        }

        //
        // GET: /Ticket/
       
        public ActionResult Index()
        {
            var model = GetTicketModel();
            return View(model);
        }

        public ActionResult TicketStatus()
        {
            var model = _db.Query<Ticket>()
                           .Join(_db.TicketStatuses, a => a.TicketStatusId, b => b.TicketStatusId,
                                 (a, b) => new {Ticket = a, TicketStatus = b})
                           .Select(t => new TicketStatusViewModel
                               {
                                   TicketId = t.Ticket.TicketId,
                                   Text = t.Ticket.Text,
                                   Title = t.Ticket.Title,
                                   TicketStatusId = t.Ticket.TicketStatusId,
                                   StatusName = t.TicketStatus.StatusName
                               });
                            
            return View(model);
        }

        public ActionResult Details(int id = 0) 
        {
            
            if (Request.IsAjaxRequest())
            {    
                //ChangeTicketLocked(id);
            }

            var model = GetMessageModel(id);
            return View(model);
        }

        //
        // GET: /Ticket/Create
        [HttpGet] 
        public ActionResult Create()
        {
            var items = _db.TicketTicketPriorities
                .Select(t => new SelectListItem{
                    Value = t.ToString(),
                    Text = t.Priority
                });

            var model = new TicketCreationViewModel();
            model.TicketTicketPriorities = _db.TicketTicketPriorities.ToArray();
 
            return View(model);
        }

        //
        // POST: /Ticket/Create

        [HttpPost]
        public ActionResult Create(TicketCreationViewModel ticket)
        {
           //TicketCreationViewModel model = ticket;
            int currentUserId = int.Parse(Membership.GetUser().ProviderUserKey.GetType().ToString());
            ticket.Tickets.CreateDate = DateTime.Now;

            if (ticket.Tickets.Locked == true) { ticket.Tickets.LockedByUserId = 1; }

            ticket.Emails.UserId = 1;

            if (ModelState.IsValid)
            {
                _db.Add(ticket.Tickets);
                _db.Add(ticket.Emails);
                _db.SaveChanges();
                return RedirectToAction("Index", "Ticket");
            }
            return View(ticket);
        }

        //
        // GET: /Ticket/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Ticket/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Ticket/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Ticket/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
