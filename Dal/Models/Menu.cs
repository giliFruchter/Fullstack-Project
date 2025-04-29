using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Menu
{
    public int Id { get; set; }

    public string Product { get; set; } = null!;

    public double Price { get; set; }
}
