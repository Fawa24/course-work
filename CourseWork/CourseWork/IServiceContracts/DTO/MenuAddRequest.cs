using Entities;

namespace IServiceContracts.DTO
{
    public class MenuAddRequest
    {
        public string MenuName { get; set; } = null!;

        public bool InStock { get; set; }

        public virtual ICollection<Dish> Dishes { get; set; } = new List<Dish>();

        public Menu ToMenu()
        {
            return new Menu()
            {
                MenuId = Guid.NewGuid(),
                MenuName = this.MenuName,
                InStock = this.InStock,
                Dishes = this.Dishes
            };
        }
    }
}
