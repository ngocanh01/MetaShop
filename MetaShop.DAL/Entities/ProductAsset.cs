namespace MetaShop.DAL.Entities
{
    public class ProductAsset
    {
        public ProductAsset()
        {
            Assets = new List<Asset>();
        }
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int AssetId { get; set; }
        public string Type { get; set; }
        public virtual Product Product { get; set; }
        public virtual Asset Asset { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }

    }
}
