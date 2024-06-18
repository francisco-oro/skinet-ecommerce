namespace Core.Entities;

public class Tag : BaseEntity
{
    public List<ProductTag> ProductTags { get; set; } = [];
}