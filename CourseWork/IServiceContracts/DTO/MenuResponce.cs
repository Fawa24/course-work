using Entities.Entities;
using System.Runtime.CompilerServices;

namespace IServiceContracts.DTO
{
    public partial class MenuResponce
    {
        public Guid MenuId { get; set; }

        public string MenuName { get; set; } = null!;

        public bool InStock { get; set; }

        public virtual ICollection<Dish> Dishes { get; set; } = new List<Dish>();

        public int CalculatePrice()
        {
            return Dishes.Select(dish => dish.DishPrice).Sum(); 
        } 

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            MenuResponce objToCompare = obj as MenuResponce;

            if (objToCompare.MenuId == this.MenuId &&
                objToCompare.MenuName == this.MenuName &&
                objToCompare.InStock == this.InStock &&
                objToCompare.Dishes.SequenceEqual(this.Dishes))
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

    public static class MenuExtencion
    {
        public static MenuResponce ToMenuResponce(this Menu menu)
        {
            return new MenuResponce()
            {
                MenuId = menu.MenuId,
                MenuName = menu.MenuName,
                InStock = menu.InStock,
                Dishes = menu.Dishes
            };
        }
    }
}
