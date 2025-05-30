public class Product
{
    private string _productName { get; set; }
    private string _productID { get; set; }
    private double _price { get; set; }
    private int _quantity { get; set; }

    public Product(string productName, string productID, double price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalProductPrice()
    {
        return _price * _quantity;
    }

    public string PackingLabel()
    {
        return $"{_productName} (ID: {_productID})";
    }

    public void DispalyProduct()
    {
        Console.WriteLine($"Product Name: {_productName}");
        Console.WriteLine($"Product ID: {_productID}");
        Console.WriteLine($"Price: {_price}");
        Console.WriteLine($"Quantity: {_quantity}");
        Console.WriteLine($"Total: {GetTotalProductPrice()}");
    }

}