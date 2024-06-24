namespace Core.Models;

public class ProductFilterParameters
{
    public Guid? BrandId { get; set; }
    public Guid? TypeId { get; set; }
    public Guid? CategoryId { get; set; }
    public Guid? TagId { get; set; }
    public Guid? ColorId { get; set; }
    public Guid? SizeId { get; set; }
}