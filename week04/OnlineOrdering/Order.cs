
public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalOrderPrice()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.TotalProductPrice();
        }
        return total + ShippingCost();
    }

    public int ShippingCost()
    {
        if (_customer.IsInUSA())
        {
            return 5; 
        }
        else
        {
            return 35; 
        }
    }

    public string PackingLabel()
    {
        string label = "Packing List:\n";
        foreach (var product in _products)
        {
            label += $"- {product.ProductName} (ID: {product.ProductID})\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"Shipping to:\n{_customer.CustomerName}\n{_customer.Address.DisplayAddress()}";
    }
}