using Entities.Entities;

namespace IServiceContracts.DTO
{
    public partial class MenuResponce
    {
        public Guid MenuId { get; set; }

        public string MenuName { get; set; } = null!;

        public bool InStock { get; set; }

        public virtual ICollection<Dish> Dishes { get; set; } = new List<Dish>();

        public int Price { get; set; }

        public void CalculateThePrice()
        {
            int price = 0;
            foreach (Dish dish in Dishes) { price = price + dish.DishPrice; }
            Price = price;
        }
    }
}
