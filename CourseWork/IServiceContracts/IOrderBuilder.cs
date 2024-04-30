using Entities.Entities;
using IServiceContracts.DTO;

namespace IServiceContracts
{
    public interface IOrderBuilder
    {
        /// <summary>
        /// Takeaway or not
        /// </summary>
        bool TakeawayOrder { get; }
        /// <summary>
        /// Use to get all the dishes from the cart
        /// </summary>
        /// <returns>All dishes from the cart</returns>
        List<CartResponce> GetDishesFromCart();
        /// <summary>
        /// Adds new dish to a cart and
        /// </summary>
        /// <param name="request">Dish to add</param>
        /// <returns>Added dish in the form of CartResponce</returns>
        CartResponce AddToCart(AddDishToCartRequest request);
        /// <summary>
        /// Builds the Order object based on its configuration
        /// </summary>
        /// <returns>Newly build Order object</returns>
        Order Build();
        /// <summary>
        /// Calculates the overall price of the order
        /// </summary>
        int CalculatePrice();
    }
}
