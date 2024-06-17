using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public Guid CategoryId { get; set; }
    [ForeignKey("Category =Id =")]
    public Category Category { get; set; }
}