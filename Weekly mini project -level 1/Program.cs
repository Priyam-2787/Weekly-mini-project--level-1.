// To create a ProductList - level 1.

Console.WriteLine("To enter a new product - follow the steps");

ProductManager productManager = new ProductManager();

while (true)
{
    Console.WriteLine("Enter the category (or 'q' to quit):");
    string category = Console.ReadLine().Trim();
    if (category.ToLower() == "q")
        break;

    Console.WriteLine("Enter the product name:");
    string productName = Console.ReadLine().Trim();

    Console.WriteLine("Enter the price:");
    double price;
    while (!double.TryParse(Console.ReadLine(), out price))
    {
        Console.WriteLine("Invalid input! Please enter a valid price:");
    }

    productManager.AddProduct(category, productName, price);
}

Console.WriteLine("\nAll products entered:");
productManager.DisplayAllProducts();
    


class ProductManager
{
    private List<Product> allProducts;

    public ProductManager()
    {
        allProducts = new List<Product>();
    }

    public void AddProduct(string category, string productName, double price)
    {
        allProducts.Add(new Product(category, productName, price));
    }

    public void DisplayAllProducts()
    {
        foreach (var product in allProducts)
        {
            Console.WriteLine($"Category: {product.Category}, Name: {product.Name}, Price: {product.Price:C}");
        }
    }
}

class Product
{
    public string Category { get; }
    public string Name { get; }
    public double Price { get; }

    public Product(string category, string name, double price)
    {
        Category = category;
        Name = name;
        Price = price;
    }
}