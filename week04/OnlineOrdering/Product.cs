class Product
{
    private string _name;
    private double _price;
    private int _quantityOfEach;
    private string _productId;

    public Product(string name, double price, string productId, int quantityOfEach)
    {
        _name = name;
        _price = price;
        _quantityOfEach = quantityOfEach;
        _productId = productId;
    }

    public double GetTotalCost()
    {
        return _price * _quantityOfEach;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }
}