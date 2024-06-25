namespace Core.Specifications;

public class ProductSpecParams
{
    private const int MaxPageSize = 50;
    public int PageIndex { get; set; } = 1;
    private int _pageSize = 6;

    public int PageSize
    {
        get => _pageSize; 
        set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
    }
    public string? Sort { get; set; }
    public Guid? BrandId { get; set; }
    public Guid? TypeId { get; set; }
    public Guid? CategoryId { get; set; }
    public Guid? TagId { get; set; }
    public Guid? ColorId { get; set; }
    public Guid? SizeId { get; set; }
}