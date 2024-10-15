//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Primitives;
//using Nop.Core;
//using Nop.Core.Domain.Common;
//using Nop.Core.Domain.Customers;
//using Nop.Core.Domain.Shipping;
//using Nop.Core.Events;
//using Nop.Services.Common;
//using Nop.Services.Configuration;
//using Nop.Services.Directory;
//using Nop.Services.Localization;
//using Nop.Services.Logging;
//using Nop.Services.Messages;
//using Nop.Services.Plugins;
//using Nop.Services.Security;
//using Nop.Services.Shipping;
//using Nop.Services.Shipping.Date;
//using Nop.Services.Shipping.Pickup;
//using Nop.Web.Areas.Admin.Factories;
//using Nop.Web.Areas.Admin.Infrastructure.Mapper.Extensions;
//using Nop.Web.Areas.Admin.Models.Shipping;
//using Nop.Web.Framework.Mvc;
//using Nop.Web.Framework.Mvc.Filters;

//namespace Nop.Web.Areas.Admin.Controllers;

//public partial class ExampleController : BaseAdminController
//{
//    #region Dates and ranges

//    public virtual async Task<IActionResult> DatesAndRanges()
//    {
//        if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageShippingSettings))
//            return AccessDeniedView();

//        //prepare model
//        var model = await _shippingModelFactory.PrepareDatesRangesSearchModelAsync(new DatesRangesSearchModel());

//        return View(model);
//    }

//    #endregion
//}
