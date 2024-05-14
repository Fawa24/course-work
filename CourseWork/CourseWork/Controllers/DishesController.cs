using CourseWork.Models;
using CourseWork.Models.EditDishModels;
using IServiceContracts;
using IServiceContracts.DTO;
using Microsoft.AspNetCore.Mvc;

namespace CourseWork.Controllers
{
    public class DishesController : Controller
    {
        private readonly IDishesService _dishesService;
        private readonly IOrderBuilder _orderBuilder;

        public DishesController(IDishesService dishesService, IOrderBuilder orderBuilder)
        {
            _dishesService = dishesService;
            _orderBuilder = orderBuilder;
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
        [Route("/edit-dish")]
        public IActionResult EditDish(Guid dishId, string returnUrl)
        {
            DishResponce dish = _dishesService.GetDishById(dishId);
            IDishModel dishModel = _dishesService.CreateDishModel(dish.DishType, dish.RestaurantType);
            EditDishModel editDishModel = new EditDishModel(dishModel, dish.RestaurantType, dish.DishType);
            return View(editDishModel);
        }

        [HttpPost]
        [Route("/add-to-cart")]
        public IActionResult AddToCart(Dictionary<string, string> dishData) 
        {
            int basePrice = _dishesService.GetBasePrice(dishData["RestorauntType"], dishData["DishType"]);
            AddDishToCartRequest addDishToCartRequest = dishData.ToAddDishToCartRequest(basePrice);
            _orderBuilder.AddToCart(addDishToCartRequest);
            return View();
        }

        [HttpGet]
        [Route("/my-cart")]
        public IActionResult MyCart()
        {
            List<CartResponce> cartDishes = _orderBuilder.GetDishesFromCart();
            return View(cartDishes);
        }

        [HttpGet]
        [Route("/edit-cart-object")]
        public IActionResult EditCartObject(Guid CartObjectId)
        {
            return View();
        }

        [HttpGet]
        [Route("/delete-from-cart")]
        public IActionResult DeleteFromCart(Guid CartObjectId)
        {
            _orderBuilder.DeleteFromCart(CartObjectId);
            List<CartResponce> cartDishes = _orderBuilder.GetDishesFromCart();
            return View("MyCart", cartDishes);
        }

        [HttpGet]
        [Route("copy-cart-object")]
        public IActionResult CopyCartObject(Guid CartObjectId)
        {
            _orderBuilder.CloneObject(CartObjectId);
            List<CartResponce> cartDishes = _orderBuilder.GetDishesFromCart();
            return View("MyCart", cartDishes);
        }
    }
}
