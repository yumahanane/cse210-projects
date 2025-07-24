public class Product
{
    private string _productName;
    private string _productID;
    private decimal _price;
    private int _quantity;

    public Product(string productName, string productID, decimal price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public decimal TotalProductCost()
    {
        return (decimal)_price * (decimal)_quantity;
    }

    public void Display()
    {
        Console.WriteLine(_productName);
        Console.WriteLine(_productID);

    }
}