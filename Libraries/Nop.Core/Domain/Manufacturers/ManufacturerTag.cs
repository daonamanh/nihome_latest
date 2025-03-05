using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Manufacturers
{
    public class ManufacturerTag : BaseEntity
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }

        public virtual ManufacturerTag ParentTag { get; set; }
        public virtual ICollection<ManufacturerTag> ChildTags { get; set; }
    }

}
