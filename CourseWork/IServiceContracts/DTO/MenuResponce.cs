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
