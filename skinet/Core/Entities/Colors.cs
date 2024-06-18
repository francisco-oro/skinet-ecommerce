namespace Core.Entities;

public class Colors : BaseEntity
{
    public string ColorName { get; set; }
    public string HexCode { get; set; }
    public string RgbCode { get; set; }
    public virtual ICollection<Product> Products { get; set; }
}