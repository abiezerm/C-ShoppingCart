// See https://aka.ms/new-console-template for more information
using ShoppingCart;

public static class Program
{
    public static void Main(string[] args)
    {
        var products = new List<Product>
        {
            new(1, "Milk", 2.99m),
            new(2, "Bread", 1.99m),
            new(3, "Cheese", 4.99m)
        };

        var userMenu = new UserMenu();

        userMenu.DisplayMenu(products);

        var option = userMenu.GetMenuChoice();

        Console.WriteLine($"You chose option {option}");
    }

}
