using CourseWork.IServiceContracts;
using CourseWork.Models;
using CourseWork.Models.EditDishModels;
using Entities;
using IServiceContracts;
using IServiceContracts.DTO;
using Microsoft.AspNetCore.Mvc;

namespace CourseWork.Controllers
{
    public class DishesController : Controller
    {
        private readonly IDishesService _dishesService;
        private readonly IOrderBuilder _orderBuilder;
        private readonly IPaymentService _paymentService;
        private readonly ICookingService _cookingService;

        public DishesController(IDishesService dishesService, IOrderBuilder orderBuilder, IPaymentService paymentService, ICookingService cookingService)
        {
            _dishesService = dishesService;
            _orderBuilder = orderBuilder;
            _paymentService = paymentService;
            _cookingService = cookingService;
        }

        [HttpGet]
        [Route("/")]
        [Route("dishes")]
        public IActionResult Dishes()
        {
            List<DishResponce> dishResponces = _dishesService.GetDishes();
            return View(dishResponces);
        }

        [HttpGet]
        [Route("edit-dish")]
        public IActionResult EditDish(Guid dishId, string returnUrl)
        {
            DishResponce dish = _dishesService.GetDishById(dishId);
            IDishModel dishModel = _dishesService.CreateDishModel(dish.DishType, dish.RestaurantType);
            EditDishModel editDishModel = new EditDishModel(dishModel, dish.RestaurantType, dish.DishType);
            return View(editDishModel);
        }

        [HttpPost]
        [Route("add-to-cart")]
        public IActionResult AddToCart(Dictionary<string, string> dishData) 
        {
            int basePrice = _dishesService.GetBasePrice(dishData["RestorauntType"], dishData["DishType"]);
            AddDishToCartRequest addDishToCartRequest = dishData.ToAddDishToCartRequest(basePrice);
            _orderBuilder.AddToCart(addDishToCartRequest);
            return View();
        }

        [HttpGet]
        [Route("my-cart")]
        public IActionResult MyCart()
        {
            List<CartResponce> cartDishes = _orderBuilder.GetDishesFromCart();
            return View(cartDishes);
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

        [HttpGet]
        [Route("pay-the-order")]
        public IActionResult ConfirmOrder(string paymentMethod) 
        {
            Order order = _orderBuilder.Build(paymentMethod);

            string path = order.GetPaymentViewPath();
            return View(order.GetPaymentViewPath(), order);
        }

        [HttpPost]
        [Route("pay-the-order")]
        public IActionResult StartCooking()
        {
            Task.Run(async () => _cookingService.Cook());
            _orderBuilder.Clear();
            return View();
        }

        [HttpGet]
        [Route("order-tracker")]
        public IActionResult OrderTracker()
        {
            return View("OrderTracker", _cookingService.GetState());
        }

        [HttpGet]
        [Route("get-the-order")]
        public IActionResult GetTheOrder()
        {
            _cookingService.StopCooking();
            return View();
        }

        [HttpGet]
        [Route("support")]
        public IActionResult Support()
        {
            return View();
        }
    }
}
