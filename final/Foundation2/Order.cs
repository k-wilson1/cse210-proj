using System;
using System.Numerics;
using System.Runtime.InteropServices;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer =customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double GetTotal()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetPrice();
        }
        return total;
    }
    public string GetOrder()
    {
        string order = "";
        foreach (var product in _products)
        {
            order += product.GetProductOrder() + "\n";
        }
        return order;
    }
    public string GetShippingLabel()
    {
        return _customer.GetCustomer();
    }
    public string GetPackingList()
    {
        return GetOrder();
    }
}