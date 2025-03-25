using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(string customerName)
    {
        _customer = new Customer(customerName);
    }

    public void ShippingAddress(string street, string city, string state, string country)
    {
        _customer.CustomerAddress(street, city, state, country);
    }

    public void AddProduct(string name, int id, int price, int quantity)
    {
        _products.Add(new Product(name, id, price, quantity));
    }

    public string DisplayPackingLabel()
    {
        string PackingLabel = "";

        foreach (Product product in _products)
        {
            PackingLabel += product.GenerateLabel();
        }

        return PackingLabel;
    }

    public string DisplayShippingLabel()
    {
        string ShippingLabel = $"Recipient: {_customer.GetCustomer()} | Address: {_customer.GetAddress()}";
        return ShippingLabel;
    }

    public int OrderTotal()
    {
        int orderTotal = 0;

        foreach (Product product in _products)
        {
            orderTotal += product.TotalPrice();
        }

        orderTotal = orderTotal + ShippingCalc();

        return orderTotal;
    }

    public int ShippingCalc()
    {
        if (_customer.Locate() == true)
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

}