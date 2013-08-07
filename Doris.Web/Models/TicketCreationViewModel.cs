using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Doris.Domain;

namespace Doris.Web.Models
{
    public class TicketCreationViewModel
    {
        public Ticket Tickets { get; set; }
        public Email Emails { get; set; }
        public IEnumerable<TicketPriority> TicketTicketPriorities { get; set; }
    }
}