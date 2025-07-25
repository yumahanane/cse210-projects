using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");



        Product product1 = new Product("Banana", "1289", 12.8, 2);

        Console.WriteLine(product1.TotalProductCost());
        product1.Display();
        Console.WriteLine(product1.DisplayAll());

        Product product2 = new Product("Tomato", "1290", 12.8, 2);

        Console.WriteLine(product2.TotalProductCost());
        product2.Display();
        Console.WriteLine(product2.DisplayAll());


        Address address = new Address("Castanheda", "Beira", "Sofala", "Mozambique");
        Console.WriteLine(address.InUSA());
        Console.WriteLine(address.Display());

        Address address2 = new Address("Broadway", "New York City", "New York", "USA");
        Console.WriteLine(address2.InUSA());
        Console.WriteLine(address2.Display());

        Customer customer = new Customer("Yuma", "Broadway, New York City, New York, USA");
        Console.WriteLine(customer.LiveInUSA());
        customer.Display();

        // Order order1 = new Order("Banana, 1289, 12.8, 2", customer);
        Order order1 = new Order();
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.SetCustomer(customer);

       
        order1.DisplayAll();


    }
}