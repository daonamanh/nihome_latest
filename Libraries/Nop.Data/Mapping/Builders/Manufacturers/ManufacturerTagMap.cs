//using Nop.Core.Domain.Manufacturers;
//using Nop.Data.Mapping;

//namespace Nop.Data.Mapping.Builders.Manufacturers
//{
//    public class ManufacturerTagMap : NopEntityTypeConfiguration<ManufacturerTag>
//    {
//        public override void Configure(NopEntityTypeBuilder<ManufacturerTag> builder)
//        {
//            builder.ToTable("ManufacturerTag");
//            builder.HasKey(tag => tag.Id);

//            builder.Property(tag => tag.Name)
//                   .IsRequired()
//                   .HasMaxLength(255);

//            builder.HasOne(tag => tag.ParentTag)
//                   .WithMany(tag => tag.ChildTags)
//                   .HasForeignKey(tag => tag.ParentId)
//                   .OnDelete(DeleteBehavior.Restrict);

//            base.Configure(builder);
//        }
//    }
//}



