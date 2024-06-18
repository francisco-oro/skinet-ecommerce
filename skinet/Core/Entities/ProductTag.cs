namespace Core.Entities;

public class ProductTag : BaseEntity
{
    public Guid TagsId { get; set; }
    public Guid TagsId { get; set; }
    public Product Product { get; set; } = null!;
    public Tag Tag { get; set; } = null!;
}