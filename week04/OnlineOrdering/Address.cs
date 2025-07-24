using System.Reflection.Metadata.Ecma335;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;


    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;

    }

    /*
    public void SetAddress(string fullAddress)
    {
        
    }

    public string GetFullAddress()
    {
        return 
    }
    */

    public bool InUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string Display()
    {
        //return _streetAddress + _city + ", " + _stateOrProvince + ", " + _country;
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}"; 

    }
}