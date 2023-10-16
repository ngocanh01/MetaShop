namespace MetaShop.Common.Dtos
{
    public class CategoryDto : BaseDto
    {
        public CategoryDto()
        {
            Products = new List<DAL.Entities.Product>();
        }
        public string Name { get; set; }
        public string Slug { get; set; }
        public int? ParentId { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public bool Status { get; set; }
        public DateTime? DeletedDate { get; set; }
        public virtual ICollection<DAL.Entities.Product> Products { get; set; }
    }
}
