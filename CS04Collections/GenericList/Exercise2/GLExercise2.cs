namespace CS04Collections.GenericList.Exercise2;

public static class GLExercise2
{
    public static void Execute()
    {
        ShoppingCart cart = new ShoppingCart();

        // Carrinho vazio
        Console.WriteLine(cart.ReturnAllProductsInCart());

        // Adicionand produtos no carrinho
        cart.AddProductToCart(new Product("Banana", 1.99, 5));
        cart.AddProductToCart(new Product("Maçã", 2.99, 3));
        cart.AddProductToCart(new Product("Melão", 6.99, 1));

        // Retornando produtos do carrinho
        Console.WriteLine(cart.ReturnAllProductsInCart());

        // Removendo produtos do carrinho
        cart.RemoveProductFromCart("Banana");

        // Adicionando Maçã novamente
        cart.AddProductToCart(new Product("Maçã", 2.99, 3));

        // Retornando produtos do carrinho
        Console.WriteLine(cart.ReturnAllProductsInCart());

        // Total do carrinho
        Console.WriteLine($"Total do carrinho: {cart.TotalPrice:C}");

        // Aplicando desconto de 10%
        cart.ApplyDiscount(10);

        // Total com desconto
        Console.WriteLine($"Total com desconto: {cart.DiscountedPrice:C}");
    }
}
