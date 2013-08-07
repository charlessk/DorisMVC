using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Doris.Domain;

namespace Doris.Web.Models
{
    public class ReplyViewModel
    {
        public int TicketId { get; set; }
        public string From { get; set; }
        public string Send { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }

   
        public string Body { get; set; }

        public string AddressBook { get; set; }
     
    }
}