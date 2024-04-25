using IServiceContracts;
using IServiceContracts.DTO;
using Microsoft.AspNetCore.Mvc;

namespace CourseWork.Controllers
{
    public class DishesController : Controller
    {
        private readonly IDishesService _dishesService;

        public DishesController(IDishesService dishesService)
        {
            _dishesService = dishesService;
        }

        [HttpGet]
        [Route("/")]
        [Route("/dishes")]
        public IActionResult Dishes()
        {
            List<DishResponce> dishResponces = _dishesService.GetDishes();
            return View(dishResponces);
        }

        [HttpGet]
        [Route("/menus")]
        public IActionResult Menus()
        {
            List<MenuResponce> menuResponces = _dishesService.GetMenus();
            MenuResponce firstMenu = menuResponces.First();
            return View(menuResponces);
        }

        // 7d58386e-0683-425a-9353-7d922297f5aa
        // 7d58386e-0683-425a-9353-7d922297f5aa
        // 1338e1e1-051b-4753-9a1b-c9ff1ca4dfb1
        // 1338e1e1-051b-4753-9a1b-c9ff1ca4dfb1
    }
}
