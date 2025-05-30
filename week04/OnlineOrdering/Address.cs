public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private bool _isUSA = false;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _isUSA = country.ToLower() == "usa";
    }

    public bool IsUSA()
    {
        return _isUSA;
    }

    public string DisplayAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}