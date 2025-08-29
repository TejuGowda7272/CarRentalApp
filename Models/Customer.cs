using System.ComponentModel.DataAnnotations;

namespace CarRentalApp.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; } = "";

        [EmailAddress, MaxLength(120)]
        public string? Email { get; set; }

        [Required, Phone, MaxLength(20)]
        public string Phone { get; set; } = "";

        [Required, MaxLength(30)]
        public string LicenceNumber { get; set; } = "";
    }
}