using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}