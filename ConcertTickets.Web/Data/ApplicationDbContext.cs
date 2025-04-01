
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ConcertTickets.Domain.Identity;

namespace ConcertTickets.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<ConcertTickets.Domain.Domain.Concert> Concert { get; set; }
    public DbSet<ConcertTickets.Domain.Domain.Ticket> Ticket { get; set; }
}
