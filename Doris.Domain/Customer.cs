using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doris.Domain
{
    public class Customer
    {
        [Key]
        public virtual int CustomerId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Address { get; set; }
        public virtual int Zip { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual int CreateBy { get; set; }
        public int CustomerTypeId { get; set; }
    }

    public class CustomerType
    {
        [Key]
        public virtual int CustomerTypeId { get; set; }
        public virtual string Name { get; set; }
    }
}
