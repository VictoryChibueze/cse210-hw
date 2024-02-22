public class Product
{
    private string _productId;
    private float _price;
    private int _quantity;


    public Product(string productId, float price,int quantity)
    {
        _productId = productId;
        _price = price;
        _quantity = quantity;

    }

    public float TotalCost(float price,int quantity)
    {
        return $"{price * quantity}";

    }

}