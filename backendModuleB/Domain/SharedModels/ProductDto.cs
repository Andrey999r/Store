namespace Courier.SharedModels;

public class ProductDto
{
    public int Id { get; set; }
    public string Code { get; set; } = "";
    public string Name { get; set; } = "";
    public string Brand { get; set; } = "";
    public string Group { get; set; } = "";
    public string? ImageUrl { get; set; }
    public decimal Price { get; set; }
}