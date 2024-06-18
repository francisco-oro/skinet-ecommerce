namespace Core.Entities;

public class Size : BaseEntity
{
    public string SizeName { get; set; }
    public virtual ICollection<Product> Products { get; set; } = [];
}