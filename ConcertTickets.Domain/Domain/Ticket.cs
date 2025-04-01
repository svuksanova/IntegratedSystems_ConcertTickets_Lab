using ConcertTickets.Domain.Domain;
using ConcertTickets.Domain.Identity;
using System.ComponentModel.DataAnnotations;

namespace ConcertTickets.Domain.Domain
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        public string? NumOfPeople { get; set; }
        public ApplicationUser? Owner { get; set; }
        public string OwnerId { get; set; }
        public Concert? ConcertBeingPlayed { get; set; }
        public Guid ConcertId { get; set; }

    }
}
