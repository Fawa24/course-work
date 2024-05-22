using CourseWork.Entities;

namespace IServiceContracts.DTO
{
    public class DishAddRequest
    {
        public string DishName { get; set; } = null!;

        public string DishType { get; set; } = null!;

        public string RestaurantType { get; set; } = null!;

        public int DishPrice { get; set; }

        public bool InStock { get; set; }

        public Dish ToDish()
        {
            return new Dish()
            {
                DishId = Guid.NewGuid(),
                DishName = this.DishName,
                DishType = this.DishType,
                InStock = this.InStock,
                DishPrice = this.DishPrice,
            };
        }
    }
}
