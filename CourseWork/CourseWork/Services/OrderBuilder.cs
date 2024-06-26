﻿using CourseWork.IServiceContracts;
using Entities;
using IServiceContracts;
using IServiceContracts.DTO;

namespace Services
{
    public class OrderBuilder : IOrderBuilder
    {
        private readonly List<CartObject> _cart;

        public Order Order { get; set; }

        public OrderBuilder()
        {
            _cart = new List<CartObject>();
        }

        public Order Build(string paymentMethod)
        {
            Order order = new Order(_cart)
            {
                Price = CalculateOverallPrice(),
                paymentStrategy = IPaymentService.CreatePaymentStrategy(paymentMethod)
            };

            return order;
        }

        public CartResponce AddToCart(AddDishToCartRequest request)
        {
            CartObject cartObject = request.ToCartObject();
            _cart.Add(cartObject);
            return cartObject.ToCartResponce();
        }

        public int CalculateOverallPrice()
        {
            int sum = 0;
            foreach (CartObject cartObject in _cart)
            {
                sum = sum + cartObject.CalculatePrice();
            }
            return sum; 
        }

        public List<CartResponce> GetDishesFromCart()
        {
            return _cart.Select(x => x.ToCartResponce()).ToList();
        }

        public void Clear()
        {
            _cart.Clear();
            Order = null;
        }

        public bool DeleteFromCart(Guid cartObjectId)
        {
            CartObject? cartObject = _cart.FirstOrDefault(obj => obj.CartObjectId == cartObjectId);

            if (cartObject == null) return false;
            
            _cart.Remove(cartObject);
            return true;
        }

		// TODO: Rewrite using ICartResponcePrototype as a return type
		public CartResponce CloneObject(Guid cartObjectId)
        {
            CartObject matchedObject = _cart.First(obj => obj.CartObjectId == cartObjectId);

            CartObject objectCopy = matchedObject.Copy() as CartObject;
            _cart.Add(objectCopy);

            return objectCopy.ToCartResponce();
        }
    }
}
