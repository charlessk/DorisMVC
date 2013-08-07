using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Doris.Web.Models
{
    public class MessageView
    {
        public virtual int MessageId { get; set; }
        public virtual int TicketId { get; set; }
        public virtual int MessageTypeId { get; set; }
        public virtual string From { get; set; }
        public virtual string ReplyTo { get; set; }
        public virtual string To { get; set; }
        public virtual string Cc { get; set; }
        public virtual string BCc { get; set; }
        public virtual string Subject { get; set; }
        public virtual int MailId { get; set; }
        public virtual string Reference { get; set; }
        public virtual string ContentType { get; set; }
        public virtual string Body { get; set; }
        public virtual DateTime? IncommingTime { get; set; }
        public virtual int ConentPath { get; set; }
        public virtual int ValidId { get; set; }
        public virtual DateTime? CreateTime { get; set; }
        public virtual int CreateBy { get; set; }
        public virtual DateTime? ChangeTime { get; set; }

        public virtual bool Locked { get; set; }
        public virtual string LockBttn { get; set; }
      
    }
}