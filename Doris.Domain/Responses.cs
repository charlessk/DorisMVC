using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doris.Domain
{
    public class Responses
    {
        [Key]
        public virtual int ResponseId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Text { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual DateTime? UpdateDate { get; set; }
        public virtual string CreateBy { get; set; }
    }
}
