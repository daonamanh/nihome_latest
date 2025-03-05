using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Manufacturers;

namespace Nop.Core.Domain.Manufacturers
{
    public class ManufacturerTagMapping : BaseEntity
    {
        public int ManufacturerId { get; set; }
        public int ManufacturerTagId { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
        public virtual ManufacturerTag ManufacturerTag { get; set; }
    }

}
