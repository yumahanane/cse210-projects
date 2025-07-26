public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName)
    {
        _customerName = customerName;
    }

    public void SetAddress(Address address)
    {
        _address = address;
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