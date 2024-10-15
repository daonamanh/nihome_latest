using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;
using System.Collections.Generic;

namespace Nop.Web.Areas.Admin.Models.Custom
{
    /// <summary>
    /// Represents a custom table search model
    /// </summary>
    public partial record CustomTableSearchModel : BaseSearchModel
    {
        #region Ctor

        public CustomTableSearchModel()
        {
            // Initialize collections as needed
            AvailableStores = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [NopResourceDisplayName("Admin.ContentManagement.Custom.CustomTables.List.SearchStore")]
        public int SearchStoreId { get; set; }

        public IList<SelectListItem> AvailableStores { get; set; }

        public string SearchName { get; set; }

        public bool HideStoresList { get; set; }

        #endregion
    }
}

