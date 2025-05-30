public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
        CheckCountry();
    }

    public bool CheckCountry()
    {
        return _address.IsUSA();
    }

    public string GetShippingLabel()
    {
        return $"{_name}\n{_address.DisplayAddress()}";
    }
}