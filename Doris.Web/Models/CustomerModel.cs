using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Doris.Web.Models
{
    public class CustomerModel
    {
        public virtual int CustomerId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Address { get; set; }
        public virtual int Zip { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual int CreateBy { get; set; }
        public int CustomerTypeId { get; set; }

    }
}