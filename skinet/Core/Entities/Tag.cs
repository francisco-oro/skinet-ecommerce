namespace Core.Entities;

public class Tag : BaseEntity
{
    public String TagName { get; set; }
    public virtual ICollection<Product> Products { get; set; } = [];
}