using Entities;
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
        /// <summary>
        /// Clones the objects and adds it to the cart
        /// </summary>
        /// <param name="cartObjectId">Object id to clone</param>
        /// <returns>Cloned object in the form of CartResponce</returns>
        CartResponce CloneObject(Guid cartObjectId);
        /// <summary>
        /// Deletes matched object from cart
        /// </summary>
        /// <param name="cartObjectId">Object id to delete</param>
        /// <returns>True if the object has been deleted successfully or false if it hasn't</returns>
        bool DeleteFromCart(Guid cartObjectId);
        /// <summary>
        /// Builds the Order object based on its configuration
        /// </summary>
        /// <returns>Newly build Order object</returns>
        Order Build();
        /// <summary>
        /// Calculates the overall price of the order
        /// </summary>
        int CalculateOverallPrice();
        /// <summary>
        /// Clears the builder
        /// </summary>
        void Clear();
    }
}
