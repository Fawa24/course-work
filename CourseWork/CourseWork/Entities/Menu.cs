namespace Entities;

public partial class Menu
{
    public Guid MenuId { get; set; }

    public string MenuName { get; set; } = null!;

    public bool InStock { get; set; }

    public virtual ICollection<Dish> Dishes { get; set; } = new List<Dish>();
}
