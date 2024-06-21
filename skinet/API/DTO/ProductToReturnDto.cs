namespace API.DTO;

public class ProductToReturnDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string PictureUrl { get; set; }
    public string ProductType { get; set; }
    public string ProductBrand { get; set; }
    public virtual IReadOnlyList<string> Tags { get; set; } = [];
    public virtual IReadOnlyList<string> Colors { get; set; } = [];
    public virtual IReadOnlyList<string> Sizes { get; set; } = [];
}