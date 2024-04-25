﻿using Entities.Entities;
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
            throw new NotImplementedException();
        }

        public List<MenuResponce> GetMenus()
        {
            throw new NotImplementedException();
        }
    }
}
