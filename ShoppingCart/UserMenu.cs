namespace ShoppingCart;

public class UserMenu
{
    public void DisplayMenu(IEnumerable<Product> products)
    {
        if(products == null ||  !products.Any()) 
        {
            Console.WriteLine("No products available");
            return;
        }

        foreach (var product in products)
        {
            Console.WriteLine($"{product.Id} - {product.Name} - {product.Price}");
        }
    }

    public int GetMenuChoice()
    {
        Console.Write("Enter choice: ");
        string? input =  Console.ReadLine();

        if(int.TryParse(input, out int choice))
        {
            return choice;
        } 
        else
        {
            Console.WriteLine("Invalid choice");
            return -1;
        }
    }
}
