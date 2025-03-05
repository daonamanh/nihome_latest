using Microsoft.AspNetCore.Mvc;
using Nop.Services.Catalog;
using Nop.Web.Areas.Admin.Factories;
using Nop.Web.Factories;

namespace Nop.Web.Components
{
    public class HomepageManufacturersViewComponent : ViewComponent
    {
        private readonly ICatalogModelFactory _manufacturerModelFactory;

        public HomepageManufacturersViewComponent(ICatalogModelFactory manufacturerModelFactory)
        {
            _manufacturerModelFactory = manufacturerModelFactory;
        }

        public IViewComponentResult Invoke()
        {
            var model = _manufacturerModelFactory.PrepareManufacturerAllModelsAsync().Result; // Use .Result to get the result synchronously
            return View(model);
        }
    }
}





