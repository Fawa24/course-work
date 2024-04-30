using Entities;
using Entities.Entities;
using IServiceContracts;
using IServiceContracts.DTO;

namespace Services
{
    public class OrderBuilder : IOrderBuilder
    {
        private readonly List<CartObject> _cart;

        public OrderBuilder()
        {
            _cart = new List<CartObject>();
        }

        public bool TakeawayOrder => TakeawayOrder;

        public CartResponce AddToCart(AddDishToCartRequest request)
        {
            CartObject cartObject = request.ToCartObject();
            _cart.Add(cartObject);
            return cartObject.ToCartResponce();
        }

        public Order Build()
        {
            return new Order(_cart)
            {
                Price = CalculatePrice(),
                TakeawayOrder = TakeawayOrder
            };
        }

        public int CalculatePrice()
        {
            throw new NotImplementedException();
        }

        public List<CartResponce> GetDishesFromCart()
        {
            return _cart.Select(x => x.ToCartResponce()).ToList();
        }


    }
}
