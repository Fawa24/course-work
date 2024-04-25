using Entities.Entities;
using IServiceContracts;
using IServiceContracts.DTO;
using Moq;
using Services;

namespace Tests
{
    public class DishServiceTests
    {
        private readonly IDishesService _dishesService;

        public DishServiceTests()
        {
            _dishesService = new DishesService(Mock.Of<DishDbContext>());
        }

        #region Arrange templates

        DishAddRequest GetDishAddRequest()
        {
            return new DishAddRequest() { DishName = "Some name", DishType = "Some type", DishPrice = 0, InStock = false, RestaurantType = "Some type" };
        }

        MenuAddRequest GetMenuAddRequest()
        {
            return new MenuAddRequest() { MenuName = "Some name", Dishes = new List<Dish>(), InStock = false };
        }

        #endregion

        #region GetDishes

        //If any dish has not be added before, GetDishes should return an empty list
        [Fact]
        public void GetDishes_EmptyList()
        {
            Assert.Empty(_dishesService.GetDishes());
        }

        //If there has been any dish or dishes added before, it should return the list of that dishes
        [Fact]
        public void GetDishes_NonEmptyList() 
        { 
            //Arrange
            DishAddRequest dishAddRequest = GetDishAddRequest();
            DishResponce dishResponce = _dishesService.AddDish(dishAddRequest);

            List<DishResponce> listFromGetDishes = _dishesService.GetDishes();

            Assert.Contains(dishResponce, listFromGetDishes);
        }

        #endregion

        #region GetMenus

        //If any menu has not be added before, GetMenus should return an empty list
        [Fact]
        public void GetMenus_EmptyList()
        {
            Assert.Empty(_dishesService.GetMenus());
        }

        //If there has been any menu or menus added before, it should return the list of that menus
        [Fact]
        public void GetMenus_NonEmptyList()
        {
            //Arrange
            MenuAddRequest menuAddRequest = GetMenuAddRequest();
            MenuResponce menuResponce = _dishesService.AddMenu(menuAddRequest);

            List<MenuResponce> listFromGetMenus = _dishesService.GetMenus();

            Assert.Contains(menuResponce, listFromGetMenus);
        }

        #endregion
    }
}