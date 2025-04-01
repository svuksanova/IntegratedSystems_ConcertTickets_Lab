using System.ComponentModel.DataAnnotations;

namespace ConcertTickets.Domain.Domain
{
    public class Concert
    {
        [Key]
        public Guid Id { get; set; }
        public string? ConcertName { get; set; }
        public DateTime ConcertDate { get; set; }
        public string? ConcertPlace { get; set; }
        public double ConcertPrice { get; set; }
        public string? ConcertImageUrl { get; set; }

    }
}
