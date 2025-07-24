public class Product
{
    private string _name;
    private int _idNumber;
    private decimal _price;
    private int _quantity;

    public string Name => _name;
    public int IdNumber => _idNumber;
    public decimal Price => _price;
    public int Quantity => _quantity;

    public Product(string name, int idNumber, decimal price)
    {
        _name = name;
        _idNumber = idNumber;
        _price = price;
    }

    public string DisplayProductInfo()
    {
        return $"Product Name: {Name} Product ID #: {IdNumber} Price: {Price}";
    }

    public decimal GetTotalCostOfProduct()
    {
        return Price * Quantity;
    }


}