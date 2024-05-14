using CourseWork.IServiceContracts.Payment;

namespace Entities;

public class Order
{
    public readonly List<CartObject> _cart = null!;
    public int Price { get; set; }
    public PaymentStrategy paymentStrategy { get; set; }

    public Order(List<CartObject> cart)
    {
        _cart = cart;
    }

    public string GetPaymentViewPath()
    {
        return paymentStrategy.getViewPath();
    }
}
