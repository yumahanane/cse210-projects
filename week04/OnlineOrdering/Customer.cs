public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer()
    {

    }

    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public bool LiveInUSA()
    {
        return _address.InUSA();
    }

    public void Display()
    {
        Console.WriteLine(_customerName);
        _address.Display();
    }
}