using Entities.Entities;
using IServiceContracts;
using IServiceContracts.DTO;

namespace Services
{
    public class DishService : IDishesService
    {
        private readonly DishDbContext _db;

        public DishService(DishDbContext db)
        {
            _db = db;
        }

        public List<DishResponce> GetDishes()
        {
            throw new NotImplementedException();
        }

        public List<MenuResponce> GetMenus()
        {
            throw new NotImplementedException();
        }
    }
}
