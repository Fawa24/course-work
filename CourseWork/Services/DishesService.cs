using CourseWork.Models.EditDishModels;
using Entities.Entities;
using IServiceContracts;
using IServiceContracts.DTO;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Services
{
    public class DishesService : IDishesService
    {
        private readonly DishDbContext _db;

        public DishesService(DishDbContext db)
        {
            _db = db;
        }

        public DishResponce AddDish(DishAddRequest request)
        {
            if (request == null) throw new ArgumentNullException("Request cant be null");

            Dish dishToAdd = request.ToDish();

            _db.Dishes.Add(dishToAdd);

            return dishToAdd.ToDishResponce();
        }

        public MenuResponce AddMenu(MenuAddRequest request)
        {
            if (request == null) throw new ArgumentNullException("Request cant be null");

            Menu menuToAdd = request.ToMenu();

            _db.Menus.Add(menuToAdd);

            return menuToAdd.ToMenuResponce();
        }

        public List<DishResponce> GetDishes()
        {
            return _db.Dishes.Select(dish => dish.ToDishResponce()).ToList();
        }

        public List<MenuResponce> GetMenus()
        {
            return _db.Menus.Include(m => m.Dishes).Select(menu => menu.ToMenuResponce()).ToList();
        }

        public DishResponce GetDishById(Guid id)
        {
            return _db.Dishes.First(dish => dish.DishId.Equals(id)).ToDishResponce();
        }

        public MenuResponce GetMenuById(Guid id)
        {
            return _db.Menus.First(dish => dish.MenuId.Equals(id)).ToMenuResponce();
        }

        public IDishModel CreateDishModel(string dishType, string restorauntType)
        {
            IRestoraunt restoraunt;
            IDishModel dishModel;

            switch (restorauntType)
            {
                case "American":
                    restoraunt = new AmericanRestoraunt();
                    break;
                case "Italian":
                    restoraunt = new ItalianRestoraunt();
                    break;
                default:
                    throw new ArgumentException("Wrong restoraunt type input");
            }

            switch (dishType)
            {
                case "Pizza":
                    dishModel = new Pizza(restoraunt);
                    break;
                case "Lasagna":
                    dishModel = new Lasagna(restoraunt);
                    break;
                default:
                    throw new ArgumentException("Wrong dish type input");
            }

            return dishModel;
        }
    }
}
