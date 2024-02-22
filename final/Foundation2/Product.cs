public class Product
{
    private string _name;
    private string _productId;
    private float _price;
    private int _quantity;


    public Product(string name,string productId, float price,int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;

    }

    public float TotalCost()
    {
        return _price * _quantity;

    }

    public string GetProductName()
    {
        return $"{_name}";
    }

    public string GetProductId()
    {
        return $"{_productId}";
    }
}