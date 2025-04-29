using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Invitation
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int? SecretaryId { get; set; }

    public DateOnly Date { get; set; }

    public int CountOfDishes { get; set; }

    public bool IsUpgradedDish { get; set; }

    public int NumberOfWaiters { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
