class Product
{
    public string Name { get; private set; }
    public string ProductId { get; private set; }
    private decimal Price { get; }
    private int Quantity { get; }

    public Product(string name, string productId, decimal price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public decimal CalculateTotalPrice()
    {
        return Price * Quantity;
    }
}