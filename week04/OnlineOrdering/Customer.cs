class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool LivesInUsa()
    {
        return _address.IsInUsa();
    }

    public string GetCustomerInfo()
    {
        return $"Name: {_name}\nAdress:\n{_address.GetFullAdress()}";
    }
}