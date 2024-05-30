using System;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product()
    {
        _name = "";
        _productId = "";
        _price= 0;
        _quantity= 0;
    }
    public Product(string name, string productId, double price)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = 1;
    }
    public void SetProduct(string name, string productId, double price)
    {
        _name = name;
        _productId = productId;
        _price = price;
    }
    public void SetProduct(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public double GetPrice()
    {
        return _price * _quantity;
    }
    public string GetProductOrder()
    {
        string order = $"Id:{_productId} Name:{_name} Price: {GetPrice()}";
        return order;
    }
}