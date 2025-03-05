namespace Nop.Core.Domain.Custom
{
    public class CustomTable : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public byte[] PictureBinary { get; set; }
        public DateTime Date { get; set; }

    }
}

