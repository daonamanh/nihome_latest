using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Media;

namespace Nop.Core.Domain.Manufacturers
{
    public class ManufacturerPicture : BaseEntity
    {
        public int ManufacturerId { get; set; }
        public int PictureId { get; set; }

        // Navigation properties
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual Picture Picture { get; set; }
    }
}

