using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Doris.Domain;

namespace Doris.Web.Models
{
    public class TicketStatusViewModel
    {

        public virtual int TicketId { get; set; }
        public virtual string Name { get; set; }
        public virtual int TicketStatusId { get; set; }
        public virtual string StatusName { get; set; }
        public virtual string Title { get; set; }
        public virtual string Text { get; set; }


  
    }
}