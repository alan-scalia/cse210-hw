public class Product
{
    private string _name;
    private int _productId;
    private float _price;
    private int _quantity;

    public Product(string name, int id, float price, int quantity)
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetId()
    {
        return _productId; 
    }

    public float TotalPrice()
    {
        float quantity = (float)_quantity;
        return _price * quantity;
    }
}