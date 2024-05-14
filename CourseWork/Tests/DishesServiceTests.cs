using Entities;
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
    }
}