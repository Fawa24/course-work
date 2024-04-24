using Entities.Entities;
using IServiceContracts;
using Moq;
using Services;

namespace Tests
{
    public class DishServiceTests
    {
        private readonly IDishesService _dishesService;

        public DishServiceTests()
        {
            _dishesService = new DishService(Mock.Of<DishDbContext>());
        }
    }
}