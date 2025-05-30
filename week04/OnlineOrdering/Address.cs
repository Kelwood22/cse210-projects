
public class Address
{
    private string _street;
    private string _city;
    private string _state;

    private string _zipCode;
    private string _country;

    public Address(string street, string city, string state, string zipCode, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _country = country;
    }

    public string DisplayAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }

    public bool InUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }
}