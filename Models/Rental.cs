using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalApp.Models
{
    public class Rental
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CarId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal TotalCost { get; set; }

        [Required]

        //bool for simplicity : true = Active, False = Closed
        public bool Status { get; set; } = true;

        [ForeignKey(nameof(CarId))]
        public virtual Car? Car { get; set; }
        
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer? Customer { get; set; }

    }
}
