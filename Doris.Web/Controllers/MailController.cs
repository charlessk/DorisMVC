using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Doris.Domain;
using Doris.Web.Models;
namespace Doris.Web.Controllers
{
    public class MailController : Controller
    {
        private readonly IDorisDataSource _db;
        public MailController(IDorisDataSource db)
        {
            _db = db;
        }

        //
        // GET: /Mail/

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Messages()
        {
            var model = new MessageView();
            return View(model);
        }

        [HttpGet]
        [OutputCache(CacheProfile = "ZeroCacheProfile")]
        public ActionResult Reply(int id)
        {
            var model = new ReplyViewModel {TicketId = id};
            
            if (Request != null  &&  Request.IsAjaxRequest())
                return PartialView("_Reply", model);
            
            return View("Reply", model);
        }

        [HttpPost]
        public ActionResult Reply(ReplyViewModel reply)
        {
            return RedirectToAction("Details", "Ticket", new{id = reply.TicketId});
        }

    }
}
