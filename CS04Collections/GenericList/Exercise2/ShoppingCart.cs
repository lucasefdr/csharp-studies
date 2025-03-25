namespace CS04Collections.GenericList.Exercise2;

internal class ShoppingCart
{
    public List<Product> Products { get; private set; } = [];
    public double TotalPrice => Products.Sum(p => p.Price * p.Quantity);
    public double DiscountedPrice { get; private set; }

    public void AddProductToCart(Product product)
    {
        var existingProduct = Products.FirstOrDefault(p => p.Name == product.Name);

        if (existingProduct != null)
        {
            existingProduct.Quantity += product.Quantity;
        }
        else
        {
            Products.Add(product);
        }
    }

    public void RemoveProductFromCart(string name)
    {
        var product = Products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (product == null)
        {
            throw new KeyNotFoundException($"Produto {name} não existe no carrinho de compras");
        }
        else
        {
            Products.Remove(product);
        }
    }

    public string ReturnAllProductsInCart()
    {
        if (Products.Count == 0)
            return "Carrinho vazio";

        return string.Join("\n", Products.Select(p => $"{p.Name} - {p.Quantity}x {p.Price:C}"));
    }

    public void ApplyDiscount(double percent)
    {
        if (percent <= 0 || percent > 100)
            throw new ArgumentOutOfRangeException(nameof(percent), "Percentual deve ser entre 0 e 100.");

        DiscountedPrice = TotalPrice * (1 - percent / 100);
    }
}
