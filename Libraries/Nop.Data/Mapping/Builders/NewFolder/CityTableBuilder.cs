using FluentMigrator.Builders.Create.Table;
using Nop.Core.Domain.Catalog;
using Nop.Data.Extensions;

//namespace Nop.Data.Mapping.Builders.NewFolder
//{
//    public partial class CityTableBuilder : NopEntityBuilder<City>
//    {
//        // Override the required MapEntity method to define table schema
//        public override void MapEntity(CreateTableExpressionBuilder table)
//        {
//            table
//                .WithColumn("CityId").AsInt32().PrimaryKey().Identity()
//                .WithColumn("Name").AsString(100).NotNullable();

//            // You can include more columns as needed
//        }
//    }
//}
namespace Nop.Data.Mapping.Builders.NewFolder
{
    public partial class ManufacturerTableBuilder : NopEntityBuilder<Manufacturer>
    {
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Name").AsString(200).NotNullable();

            // Foreign key relationship to City table
            table.ForeignKey("FK_Manufacturer_City", "CityId", "City", "CityId");
        }
    }
}
