using FluentMigrator.Builders.Create.Table;
using Nop.Core.Domain.Custom;
using Nop.Data.Extensions;

namespace Nop.Data.Mapping.Builders.Custom
{
    /// <summary>
    /// Represents a custom entity builder
    /// </summary>
    public partial class CustomTableBuilder : NopEntityBuilder<CustomTable>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(CustomTable.Name)).AsString(400).NotNullable()
                .WithColumn(nameof(CustomTable.Description)).AsString(1000).Nullable()
                // Add a column for storing the path or URL of the picture
                .WithColumn(nameof(CustomTable.PictureUrl)).AsString(1000).Nullable()
                // Optionally, you could add a column for storing binary picture data
                .WithColumn(nameof(CustomTable.PictureBinary)).AsBinary().Nullable();
        }

        #endregion
    }
}

