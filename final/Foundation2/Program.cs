using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer= new Customer();
        Address address= new Address();
        Order order= new Order(customer);
        order.AddProduct(new Product("Laptop", "Lp109", 109.99));
        order.AddProduct(new Product("Computer mouse", "Cpt86", 32.99));
        order.AddProduct(new Product("Computer bag", "Cptbg98", 57.89));
        
        customer.SetCustomer("Sarah", "Smith", address);
        address.SetAddress("103 Lucky Dr", "Greenville", "Alabama", "USA");
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order.GetShippingLabel());
        double shippingCost = customer.IsInUsa() ? 5 : 35;
        double totalWithShipping = order.GetTotal() + shippingCost;
        Console.WriteLine($"Total: ${order.GetTotal()}");
        Console.WriteLine($"Total with Shipping: ${totalWithShipping}");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order.GetPackingList());
        
        Customer customer1 = new Customer();
        Address address1= new Address();
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Reebok Shoes","RBS99", 99.99));
        order1.AddProduct(new Product("ShoeLaces", "SL10", 9.99));
        customer1.SetCustomer("Brian", "Green", address1);
        address1.SetAddress("4983 West End", "Cyress", "Alberta", "Cananda");
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order1.GetShippingLabel());
        double shippingCost1 = customer1.IsInUsa() ? 5 :35;
        double totalWithShipping1 = order1.GetTotal() + shippingCost1;
        Console.WriteLine($"Total: ${order1.GetTotal()}");
        Console.WriteLine($"Total with Shipping: ${totalWithShipping1}");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order1.GetPackingList());
    }
}