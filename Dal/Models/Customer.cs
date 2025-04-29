using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string LastName { get; set; } = null!;

    public string PhoneNum { get; set; } = null!;

    public virtual ICollection<Invitation> Invitations { get; set; } = new List<Invitation>();
    public Customer(int id, string firstName, string lastName,string phoneNum) {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        PhoneNum = phoneNum;
        Invitations = new List<Invitation>();
    }
}
