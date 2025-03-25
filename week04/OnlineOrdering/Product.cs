using System;

public class Product
{
    private string _name;
    private int _id;
    private int _price;
    private int _quantity;
    private int totalPrice;

    public Product(string name, int id, int price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public int TotalPrice()
    {
        totalPrice = _price * _quantity;
        return totalPrice;
    }

    public string GenerateLabel()
    {
        string productLabel = $"[Product: {_name} ID: {_id}]\n";
        return productLabel;
    }

}