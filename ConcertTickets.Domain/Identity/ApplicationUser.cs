﻿using Microsoft.AspNetCore.Identity;
namespace ConcertTickets.Domain.Identity
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
