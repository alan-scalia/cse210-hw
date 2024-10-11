public class Order 
{
    List<Product> _products = [];
    Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public Order(Customer customer, Product product)
    {
        _customer = customer;
        AddProduct(product);
    }

    public string GetCustomerName()
    {
        return _customer.GetName();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float TotalCost()
    {
        float sumPrices = 0;
        float shipping = 5.0f;

        foreach (Product product in _products)
        {
            sumPrices += product.TotalPrice();
        }

        if(_customer.IsInUsa())
        {
            shipping += 30.0f;
        }

        return sumPrices + shipping;
    }

    public void PackLabel()
    {
        
        foreach(Product product in _products)
        {
            Console.Write($"ID: {product.GetId()} - {product.GetName()}\n");
        }
    }

    public void ShippingLabel()
    {
        Console.Write($"{_customer.GetName()}\n{_customer.GetAddress()}");
    }
}