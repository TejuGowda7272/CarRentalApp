
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalApp.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Make { get; set; } = "";

        [Required, MaxLength(50)]
        public string Model { get; set; } = "";

        [Range(1980, 2100)]
        public int Year { get; set; }

        [Required, MaxLength(20)]
        public string? LicensePlate { get; set; }

        [Range(0, 999999), Column(TypeName = "decimal(18,2)")]
        public decimal DailyRate { get; set; }

        public bool IsAvailable { get; set; } = true;
    }
}