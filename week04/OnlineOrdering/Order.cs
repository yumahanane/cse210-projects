public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order()
    {

    }

    public void DisplayAll()
    {
        List<decimal> costList = new List<decimal>();

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

        decimal totalOrderCost = costList.Sum() + shippingCost;
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