using Nop.Web.Framework.Models;
using System.ComponentModel.DataAnnotations; // Add this line
namespace Nop.Web.Areas.Admin.Models.Custom
{
    public record CustomTableModel : BaseNopEntityModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        // Property to store the image URL or path
        public string PictureUrl { get; set; }

        // Optional property for uploading an image
        public IFormFile PictureUpload { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
       
    }
}

