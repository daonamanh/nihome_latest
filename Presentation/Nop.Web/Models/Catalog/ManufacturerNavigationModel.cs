using Nop.Web.Framework.Models;
using Nop.Web.Models.Media;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Nop.Web.Models.Catalog;

public partial record ManufacturerNavigationModel : BaseNopModel
{
    public ManufacturerNavigationModel()
    {
        Manufacturers = new List<ManufacturerBriefInfoModel>();
    }

    public IList<ManufacturerBriefInfoModel> Manufacturers { get; set; }

    public int TotalManufacturers { get; set; }
}

public partial record ManufacturerBriefInfoModel : BaseNopEntityModel
{
    public int? CityId { get; set; }
    public IList<SelectListItem> AvailableCities { get; set; }
    public decimal Price { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string PictureUrl { get; set; }
    public PictureModel PictureModel { get; set; }
    public string SeName { get; set; }

    public bool IsActive { get; set; }
}