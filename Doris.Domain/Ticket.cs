using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doris.Domain
{
    public class Ticket
    {

        [Key]
        public virtual int TicketId { get; set; }
        public virtual string Name { get; set; }
        public virtual int TicketStatusId { get; set; }
        public virtual int TicketPriorityId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Text { get; set; }


        public virtual DateTime? CreateDate { get; set; }
        public virtual DateTime? UpdateDate { get; set; }
        public virtual DateTime? AwaitingDate { get; set; }

        public virtual bool Locked { get; set; }
        public virtual int? LockedByUserId { get; set; }
        public virtual int UserId { get; set; }
    }

    public class TicketPriority
    {
        [Key]
        public virtual int PriorityId { get; set; }
        public virtual string Priority { get; set; }
  
    }

    public class TicketStatus
    {
        [Key]
        public virtual int TicketStatusId { get; set; }
        public virtual string StatusName { get; set; }
    }

}
