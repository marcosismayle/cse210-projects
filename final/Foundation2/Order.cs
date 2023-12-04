using System;
using System.Collections.Generic;
using System.Linq;

class Order
{
    private List<Product> Products;
    private Customer Customer;

    public Order(Customer customer)
    {
        Products = new List<Product>();
        Customer = customer;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = Products.Sum(product => product.CalculateTotalPrice());
        totalCost += Customer.InUSA() ? 5.0m : 35.0m;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = $"Packing Label for {Customer.Name}:\n";
        foreach (var product in Products)
        {
            packingLabel += $"{product.Name} - Product ID: {product.ProductId}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Shipping Label for {Customer.Name}:\n";
        shippingLabel += Customer.Address.GetAddressString();
        return shippingLabel;
    }
}
