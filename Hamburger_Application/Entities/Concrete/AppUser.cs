﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hamburger_Application.Entities.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public AppUser()
        {
            CreationTime = DateTime.Now;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Address { get; set; }
        public bool IsActive { get; set; }
        public bool IsDark { get; set; } = false;
        public DateTime CreationTime { get; set; }
        [NotMapped]
        public int ConfirmCode { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
