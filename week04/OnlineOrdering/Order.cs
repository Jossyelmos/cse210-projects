public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        double totalShippingCost = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalProductPrice();
        }
        if (_customer.CheckCountry())
        {
            totalShippingCost = total + 5;
        }
        else
        {
            totalShippingCost = total + 35;
        }
        return totalShippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing label: \n";

        foreach (Product product in _products)
        {
            label += $"{product.PackingLabel()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label: \n{_customer.GetShippingLabel()}";
    }
}