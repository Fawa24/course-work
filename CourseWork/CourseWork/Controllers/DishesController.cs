using CourseWork.Models.EditDishModels;
using IServiceContracts;
using IServiceContracts.DTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

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

        [HttpGet]
        [Route("/edit-menu")]
        public IActionResult EditMenu(Guid menuId)
        {
            MenuResponce menu = _dishesService.GetMenuById(menuId);
            return View(menu);
        }

        [HttpGet]
        [Route("/edit-dish")]
        public IActionResult EditDish(Guid dishId, string returnUrl)
        {
            DishResponce dish = _dishesService.GetDishById(dishId);
            IDishModel dishModel = _dishesService.CreateDishModel(dish.DishType, dish.RestaurantType);
            return View(dishModel);
        }

        [HttpPost]
        [Route("/add-to-cart")]
        public IActionResult AddToCart([FromBody] Dictionary<string, int> dishData)//JObject formData)
        {
            /*Dictionary<string, int> dishData = new Dictionary<string, int>();

            foreach (JProperty property in formData.Properties())
            {
                dishData.Add(property.Name, Convert.ToInt16(formData[property]));
            }

            HttpContext.Response.ContentType = "application/json";*/

            return View(dishData);
        }
    }
}
