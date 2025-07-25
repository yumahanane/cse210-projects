public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, string address)
    {
        _customerName = customerName;

        string[] parts = address.Split(", ");

        string streetAddress = parts[0];
        string city = parts[1];
        string stateOrProvince = parts[2];
        string country = parts[3];

        Address customerAddress = new Address(streetAddress, city, stateOrProvince, country);
        _address = customerAddress;

    }

    public bool LiveInUSA()
    {
        return _address.InUSA();
    }

    public void Display()
    {
        Console.WriteLine($"{_customerName}\n{_address.Display()}");
    }
}