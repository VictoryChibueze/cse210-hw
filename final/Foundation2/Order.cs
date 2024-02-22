public class Order
{
    private List <Product> _products = new List <Product>();
    private Customer _customers;

    public Order(Customer customers)
    {
        _customers = customers;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float ProductTotalCost()
    {
        float totalCost = _products.Sum(product => product.TotalCost());
        float shippingCost = _customers.IsUSACustomer() ? 5 : 35;
        return totalCost + shippingCost;


    }

    public string PackingLabel()
    {
        return string.Join("\n",_products.Select(product => $"{product.GetProductName()} (ID: {product.GetProductId()})"));
    }

    public string ShippingLabel()
    {
        return $"{_customers.GetCustomerName()} {_customers.GetCustomerAddress()}";
    }


}