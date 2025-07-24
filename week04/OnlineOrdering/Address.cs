using System.Reflection.Metadata.Ecma335;

public class Address
{
    private string _fullAddress;

    public Address()
    {

    }
    public void SetAddress(string fullAddress)
    {
        _fullAddress = fullAddress;
    }

    public string GetFullAddress()
    {
        return _fullAddress;
    }

    public bool InUSA()
    {
        return true; // only stub for now
    }

    public string Display()
    {
        return _fullAddress; // not sure what "with newline characters where appropriate" means
    }
}