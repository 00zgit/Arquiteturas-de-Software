public class Seller
{
    public Seller() { }

    public void showProducts()
    {
        return new List<Product>();
    }
    public string sell(Product product, int qtd)
    {
        return $"\nSold: {product} x{qtd}";
    }
}

public class Buyer
{
    public Buyer() { }

    public static void Main()
    {
        Mediator m = new(new Seller());
        m.showProducts();
        m.sell(product,qtd);

    }
}

public class Mediator
{
    public Mediator() { }

    public void showProducts()
    {
        Seller s = new();
        return s.showProducts();
    }
    public string sell(Product product, int qtd)
    {
        Seller s = new();
        return s.sell(product,qtd);
    }
}

public class Product
{
    public Product() { }
}