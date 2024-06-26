﻿using System;
using System.Collections.Generic;

namespace CourseWork.Entities;

public partial class Dish
{
    public Guid DishId { get; set; }

    public string DishType { get; set; } = null!;

    public string RestaurantType { get; set; } = null!;

    public int DishPrice { get; set; }

    public bool InStock { get; set; }

    public string DishName { get; set; } = null!;

    public virtual ICollection<Menu> Menus { get; set; } = new List<Menu>();
}
