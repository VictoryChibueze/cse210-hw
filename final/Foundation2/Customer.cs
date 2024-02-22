public class Customer
{
    private string _name;
    private Address _customerAddress;

    public Customer(string name)
    {
        _name = name;
    }   

    public bool IsUSACustomer()
    {
        return _customerAddress.IsAmerica();
    }
    public string GetCustomerAddress()
    {
        return $"{_customerAddress}";

    }

    public string GetCustomerName()
    {
        return $"{_name}";
    }

}