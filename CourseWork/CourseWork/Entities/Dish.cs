namespace Entities;

public partial class Dish
{
    public Guid DishId { get; set; }

    public string DishName { get; set; } = null!;

    public string DishType { get; set; } = null!;

    public string RestaurantType { get; set; } = null!;

    public int DishPrice { get; set; }

    public bool InStock { get; set; }

    public virtual ICollection<Menu> Menus { get; set; } = new List<Menu>();
}
