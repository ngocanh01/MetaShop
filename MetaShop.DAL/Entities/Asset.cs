namespace MetaShop.DAL.Entities
{
    public class Asset : BaseEntity
    {
        public string FileName { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
