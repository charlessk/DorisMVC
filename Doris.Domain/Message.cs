using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doris.Domain
{
    public class Message
    {
        [Key]
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
        public virtual int CreatBy { get; set; }
    }

    public class MessageType
    {
        [Key]
        public virtual int TypeId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Comments { get; set; }

    }
   
    public class MessageAttachment
    {
        [Key]
        public virtual int AttachmentId { get; set; }
        public virtual int MessageId { get; set; }
        public virtual string Filename { get; set; }
        public virtual int ContenSize { get; set; }
        public virtual string ContentType { get; set; }
        public virtual DateTime? CreateTime { get; set; }
        public virtual int CreateBy { get; set; }
        public virtual DateTime? ChangeTime { get; set; }
        public virtual int ChangeBy { get; set; }
    }


}
