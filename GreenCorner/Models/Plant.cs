namespace GreenCorner.Models;

public class Plant
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; } // For simplicity in this demo, this will be a resource name or URL
    public decimal Price { get; set; }
    public string Difficulty { get; set; } // Easy, Medium, Hard
    public string LightRequirement { get; set; } // Low, Medium, High
    public bool IsPopular { get; set; }
    public string Tag { get; set; } // "New", "Shade-loving", etc.
}
