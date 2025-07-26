public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order()
    {

    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }


    public void DisplayAll()
    {
        //Create a list that will hold the cost of each product
        List<double> costList = new List<double>();

        //Iterate through the list of products 
        //Call a Production method to get the product cost
        //Add each one to the list created above
        foreach (Product product in _products)
        {
            costList.Add(product.TotalProductCost());
        }

        //Call a Customer method to check if the customer lives in the USA
        //to set the shipping cost
        int shippingCost = 0;

        if (_customer.LiveInUSA() == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        //Calculate the total price of the order by adding the cost of each product;
        // then adding to it the shipping cost
        double totalOrderCost = costList.Sum() + shippingCost;
        Console.WriteLine($"Total Price: {totalOrderCost}");
        Console.WriteLine();

        //Iterate through the product list
        //Display the name and id of each product
        Console.WriteLine($"Packing Label: ");
        foreach (Product product in _products)
        {
            product.Display();
        }
        Console.WriteLine();

        //Display the name and address of the customer
        Console.WriteLine($"Shipping Label: ");
        _customer.Display();

        Console.WriteLine("_______________________________________");

    }
}