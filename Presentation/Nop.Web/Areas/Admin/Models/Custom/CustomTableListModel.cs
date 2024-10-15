using Nop.Web.Framework.Models;

namespace Nop.Web.Areas.Admin.Models.Custom;

/// <summary>
/// Represents a news item list model
/// </summary>
public partial record CustomTableListModel : BasePagedListModel<CustomTableModel>
{
}