using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();

        Console.WriteLine("Order 1");

        Product product1 = new Product("Banana", "1289M", 12.80, 5);
        Product product2 = new Product("Tomato", "1290P", 10.50, 10);
        Product product3 = new Product("Cucumber", "1291K", 7.20, 6);

        //Address address1 = new Address("Broadway Steet", "New York City", "New York", "USA");

        Customer customer1 = new Customer("Mary Hernandez", "Broadway Street, New York City, New York, USA");

        Order order1 = new Order();
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        order1.SetCustomer(customer1);

        order1.DisplayAll();
        
        // -----------------------------------------------
        Console.WriteLine();
        Console.WriteLine("Order 2");


        Product product4 = new Product("Beef", "PE10061", 49.90, 2);
        Product product5 = new Product("Prawn", "W2104", 40, 30);


        //Address address2 = new Address("Fernando Pedro", "Chimoio", "Mania", "Mozambique");

        Customer customer2 = new Customer("Sheila Pedro", "Fernando Noronha Street, Chimoio, Manica, Mozambique");

        Order order2 = new Order();
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        order2.SetCustomer(customer2);

        order2.DisplayAll();

        // -------------------------------------------------------
        
        Console.WriteLine();
        Console.WriteLine("Order 3");


        Product product6 = new Product("Pan", "56M01", 11.90, 1);
        Product product7 = new Product("Knife", "8YN90", 5.50, 3);
        

        //Address address3 = new Address("1040 Printech Ave", "Honeydew", "Johannesburg", "South Africa");

        Customer customer3 = new Customer("Alvaro Khumalo", "1040 Printech Ave, Honeydew, Johannesburg, South Africa");

        Order order3 = new Order();
        order3.AddProduct(product6);
        order3.AddProduct(product7);

        order3.SetCustomer(customer3);

        order3.DisplayAll();

    }
}