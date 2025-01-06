namespace MetaShop.Common.Dtos
{
    public class AssetDto : BaseDto
    {
        public string FileName { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
