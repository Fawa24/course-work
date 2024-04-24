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
        /// Method for getting all the menus from the database
        /// </summary>
        /// <returns>List of all the menus in the form of MenuResponce</returns>
        List<MenuResponce> GetMenus();
    }
}
