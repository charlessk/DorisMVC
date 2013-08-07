using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doris.Domain
{
    public class Email
    {
        [Key]
        public virtual string Address { get; set; }
        public virtual int UserId { get; set; }
    }

    public class EmailServer
    {
        [Key]
        public virtual int ServerId { get; set; }
        public virtual string ServerName { get; set; }
        public virtual string ServerIp { get; set; } //Byte[] or other data types?
        public virtual int ServerPort { get; set; }
    }
    
}
