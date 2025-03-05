using Nop.Web.Framework.Models;
using Nop.Web.Models.Media;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Nop.Web.Models.Catalog;

public partial record ManufacturerModel : BaseNopEntityModel
{
    public ManufacturerModel()
    {
        PictureModel = new PictureModel();
        FeaturedProducts = new List<ProductOverviewModel>();
        CatalogProductsModel = new CatalogProductsModel();
    }
    public int City { get; set; }
    public int? CityId { get; set; }
    public IList<SelectListItem> AvailableCities { get; set; } = new List<SelectListItem>();
    public int DistrictId { get; set; }
    public IDictionary<int, IList<SelectListItem>> AvailableDistricts { get; set; } = new Dictionary<int, IList<SelectListItem>>
{
    { 1, new List<SelectListItem> // Districts for Tphcm
        {
            new SelectListItem { Text = "District 1", Value = "101" },
            new SelectListItem { Text = "District 2", Value = "102" },
            new SelectListItem { Text = "District 3", Value = "103" }
        }
    },
    { 2, new List<SelectListItem> // Districts for Hanoi
        {
            new SelectListItem { Text = "Ba Dinh", Value = "201" },
            new SelectListItem { Text = "Hoan Kiem", Value = "202" },
            new SelectListItem { Text = "Dong Da", Value = "203" }
        }
    },
    { 3, new List<SelectListItem> // Districts for Danang
        {
            new SelectListItem { Text = "Hai Chau", Value = "301" },
            new SelectListItem { Text = "Thanh Khe", Value = "302" },
            new SelectListItem { Text = "Son Tra", Value = "303" }
        }
    }
};
    public decimal Price { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string MetaKeywords { get; set; }
    public string MetaDescription { get; set; }
    public string MetaTitle { get; set; }
    public string SeName { get; set; }

    public PictureModel PictureModel { get; set; }

    public IList<ProductOverviewModel> FeaturedProducts { get; set; }

    public CatalogProductsModel CatalogProductsModel { get; set; }
}