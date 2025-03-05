//using Nop.Core.Domain.Manufacturers;
//using Nop.Data.Mapping;

//namespace Nop.Data.Mapping.Builders.Manufacturers
//{
//    public class ManufacturerTagMappingMap : NopEntityTypeConfiguration<ManufacturerTagMapping>
//    {
//        public override void Configure(NopEntityTypeBuilder<ManufacturerTagMapping> builder)
//        {
//            builder.ToTable("ManufacturerTagMapping");
//            builder.HasKey(mapping => mapping.Id);

//            builder.HasOne(mapping => mapping.Manufacturer)
//                   .WithMany()
//                   .HasForeignKey(mapping => mapping.ManufacturerId);

//            builder.HasOne(mapping => mapping.ManufacturerTag)
//                   .WithMany()
//                   .HasForeignKey(mapping => mapping.ManufacturerTagId);

//            base.Configure(builder);
//        }
//    }
//}


