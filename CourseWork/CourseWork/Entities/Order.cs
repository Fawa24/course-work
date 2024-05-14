namespace Entities;

public class Order
{
    private readonly List<CartObject> _cart = null!;
    public int Price { get; set; }

    public Order(List<CartObject> cart)
    {
        _cart = cart;
    }
}
