using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Doris.Web.Models
{
    public class TicketPriorityModel
    {
        public int PriorityId { get; set; }
        public string Priority { get; set;}
        
    }
   
}