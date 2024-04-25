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
        /// Method for getting all the menus from the database
        /// </summary>
        /// <returns>List of all the menus in the form of MenuResponce</returns>
        List<MenuResponce> GetMenus();
        /// <summary>
        /// Adds new menu to a Db
        /// </summary>
        /// <param name="request">Menu to add</param>
        /// <returns>Menu in the form of MenuResponce with newly generated MenuId</returns>
        MenuResponce AddMenu(MenuAddRequest request);
    }
}
