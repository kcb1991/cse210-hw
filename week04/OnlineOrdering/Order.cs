public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public decimal GetSubtotal()
    {
        decimal subtotal = 0;

        foreach (Product product in _products)
        {
            subtotal += product.Price;
        }
        return subtotal;
    }
    public decimal GetShippingCost()
    {
        if (_customer.LivesInUSA())
        {
            return 5.00m;
        }
        else
        {
            return 35.00m;
        }
    }
    public decimal GetTotalCost()
    {
        return GetSubtotal() + GetShippingCost();
    }
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"Product Name: {product.Name} ID #: {product.IdNumber}";
        }
        return label;
    }
    public string GetShippingLabel()
{
    Address address = _customer.Address;

    return $"Shipping Label:\nName: {_customer.CustomerName}\nAddress: {address.FormatAddress()}";
}
}