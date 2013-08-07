using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doris.Domain
{
    public class Zip
    {
        [Key]
        public virtual int ZipCode { get; set; }
        public virtual string City { get; set; }
        public virtual string Txt { get; set; }
        public virtual string Url { get; set; }
        public virtual int Municipality { get; set; }
        public virtual int County { get; set; }
    }
}
