namespace ShoppingCart;

public class Product
{
    public Product(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; } = 0.0m;
}
