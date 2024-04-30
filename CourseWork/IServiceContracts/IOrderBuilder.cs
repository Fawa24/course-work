using IServiceContracts.DTO;

namespace IServiceContracts
{
    public interface IOrderBuilder
    {
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
    }
}
