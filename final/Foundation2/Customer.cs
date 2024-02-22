public class Customer
{
    private string _name;
    private Address _customerAddress;

    public Customer(string name,Address address)
    {
        _name = name;
        _customerAddress = address;
    }   

    public bool IsUSACustomer()
    {
        return _customerAddress.IsAmerica();
    }
    public string GetCustomerAddress()
    {
        return $" {_customerAddress.DisplayAddress()}";

    }

    public string GetCustomerName()
    {
        return $"{_name}";
    }

}