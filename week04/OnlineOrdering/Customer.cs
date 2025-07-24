public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetCustomerDetails()
    {
        return $"Name: {_customerName}\n Address: {_address.FormatAddress()}\n Lives in USA: {LivesInUSA()}";
    }

}