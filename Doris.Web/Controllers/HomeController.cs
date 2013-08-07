using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Doris.Domain;
using Doris.Web.Models;

namespace Doris.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDorisDataSource _db;
       
        public HomeController(IDorisDataSource db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test(int id = 0)
        {
            if (Request.IsAjaxRequest())
            {
                
            }
            var model = _db.Query<Ticket>()
                           .Select(t=> new TicketViewModel
                               {
                                   TicketId = t.TicketId,
                                   Locked = t.Locked
                               });

            return View(model);
        }
       
        [HttpPost]
        public ActionResult Test(TicketViewModel viewModel, int id = 0)
        {
            if (Request.IsAjaxRequest())
            {

            }
            var model = _db.Query<Ticket>()
                           .Select(t => new TicketViewModel
                           {
                               TicketId = t.TicketId,
                               Locked = t.Locked
                           });

            return View(model);
        }



    }
}
