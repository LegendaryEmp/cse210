public class Customer
{
    private string _name;
    private Address address;

    public Customer(string name, Address address)
    {
        this._name = name;
        this.address = address;
    }

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return address;
    }
}