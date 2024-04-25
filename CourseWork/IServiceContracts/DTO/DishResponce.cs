using Entities.Entities;
using System.Runtime.CompilerServices;

namespace IServiceContracts.DTO
{
    public partial class DishResponce
    {
        public Guid DishId { get; set; }

        public string DishName { get; set; } = null!;

        public string DishType { get; set; } = null!;

        public string RestaurantType { get; set; } = null!;

        public int DishPrice { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            DishResponce objToCompare = obj as DishResponce;

            if (objToCompare.DishId == this.DishId &&
                objToCompare.DishName == this.DishName &&
                objToCompare.DishPrice == this.DishPrice &&
                objToCompare.DishType == this.DishType &&
                objToCompare.RestaurantType == this.RestaurantType)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public static class DishExtencion
    {
        public static DishResponce ToDishResponce(this Dish dish)
        {
            return new DishResponce
            {
                DishId = dish.DishId,
                DishName = dish.DishName,
                DishType = dish.DishType,
                RestaurantType = dish.RestaurantType,
                DishPrice = dish.DishPrice
            };
        }
    }
}
