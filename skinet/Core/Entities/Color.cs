namespace Core.Entities;

public class Color
{
    public string ColorName { get; set; }
    public string HexCode { get; set; }
    public virtual ICollection<Product> Products { get; set; }
}