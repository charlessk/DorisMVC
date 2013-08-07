using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Doris.Web.Models
{
    public class TicketViewModel
    {
        
        public virtual int TicketId { get; set; }
        public virtual string Name { get; set; }
       // public virtual int TicketStatusID { get; set; }
        public virtual int TicketPriorityId { get; set; }
        public virtual string Title { get; set; }
        [MaxLength(1000, ErrorMessage = "Maximum 1000 words")]
        public virtual string Text { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public virtual DateTime? CreateDate { get; set; }
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
       // public virtual DateTime? UpdatedDate { get; set; }
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        //public virtual DateTime? AwaitingDate { get; set; }

        public virtual bool Locked { get; set; }
      //  public virtual int LockedByUserID { get; set; }
       // public virtual int UserID { get; set; }

       // public virtual string UserName { get; set; }

    }


}