public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    /*
    public Order(string productInfo, Customer Customer)
    {
        _customer = Customer;

        string[] parts = productInfo.Split(", ");

        string productName = parts[0];
        string productID = parts[1];
        double price = double.Parse(parts[2]);
        int quantity = int.Parse(parts[3]);

        Product product = new Product(productName, productID, price, quantity);
        _products.Add(product);
    }
    */
    public Order()
    {

    }
    public void SetCustomer(Customer Customer)
    {
        _customer = Customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }


    public void DisplayAll()
    {
        List<double> costList = new List<double>();

        foreach (Product product in _products)
        {
            costList.Add(product.TotalProductCost());

        }

        int shippingCost = 0;

        if (_customer.LiveInUSA() == true)
        {
            shippingCost = 5;
        }

        else
        {
            shippingCost = 35;
        }

        double totalOrderCost = costList.Sum() + shippingCost;
        Console.WriteLine($"Total Price: {totalOrderCost}");

        Console.WriteLine($"Packing Label: ");
        foreach (Product product in _products)
        {
            product.Display();
        }

        //Console.WriteLine($"Shipping Label: {_customer.Display()} "); // Argument 1: 
        // cannot convert from 'void' to 'object?' Error CS1503 

    }
}