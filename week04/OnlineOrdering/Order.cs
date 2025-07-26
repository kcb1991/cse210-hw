public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products ?? new List<Product>();
        
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
    public string FormatTotalCost()
    {
        return $"Total: ${GetTotalCost()}";
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"Product Name: {product.Name}\nID #: {product.IdNumber}\nQuantity: {product.Quantity}\n";
        }
        return label;
    }
    public string GetShippingLabel()
{
    Address address = _customer.Address;

    return $"Shipping Label\n{_customer.CustomerName}\n{address.FormatAddress()}\n";
}
}