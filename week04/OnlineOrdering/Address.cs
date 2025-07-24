using System.Security.Cryptography.X509Certificates;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public string FormatAddress()
    {
        return $"{_streetAddress}\n{_city},{_state}\n{_country}";
    }
    public bool IsInUSA()
    {
        string countryUpper = _country.ToUpper().Trim();

        if (countryUpper == "USA" || countryUpper == "UNITED STATES" || countryUpper == "UNITED STATES OF AMERICA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}