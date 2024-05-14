using CourseWork.Models.EditDishModels;
using IServiceContracts.DTO;

namespace IServiceContracts
{
    public interface IDishesService
    {
        /// <summary>
        /// Method for getting all the dishes from the database
        /// </summary>
        /// <returns>List of all the dishes in the form of DishResponce</returns>
        List<DishResponce> GetDishes();
        /// <summary>
        /// Adds new dish to a Db
        /// </summary>
        /// <param name="request">Dish to add</param>
        /// <returns>Dish in the form of DishResponce with newly generated DishId</returns>
        DishResponce AddDish(DishAddRequest request);
        /// <summary>
        /// Use to get Dish from database by its id 
        /// </summary>
        /// <param name="id">Id to search</param>
        /// <returns>Matches dish object in the form of DishResponce</returns>
        DishResponce GetDishById(Guid id);
        /// <summary>
        /// Creates an IDishModel object that is used to create a DishEdit view
        /// </summary>
        /// <param name="dishType">Dish type to create</param>
        /// <param name="restorauntType">Restoraunt dish was created in</param>
        /// <returns>Dish model object</returns>
        IDishModel CreateDishModel(string dishType, string restorauntType);
        /// <summary>
        /// Returns stock price for a product
        /// </summary>
        /// <param name="restorauntType">Restoraunt type</param>
        /// <param name="dishType">Dish type</param>
        /// <returns>Price of the matching product</returns>
        int GetBasePrice(string restorauntType, string dishType);
    }
}
