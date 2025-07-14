using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StokTakip.Models
{
    [Table("WholesalerDebtMovements")]
    public class WholesalerDebtMovement
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Wholesaler")]
        public int WholesalerId { get; set; }
        public virtual Wholesaler Wholesaler { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string MovementType { get; set; } = string.Empty; // Alış Faturası, Ödeme, İade

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [StringLength(50)]
        public string? DocumentNumber { get; set; }

        [StringLength(200)]
        public string? Description { get; set; }

        [StringLength(50)]
        public string UserName { get; set; } = "Admin";

        public DateTime MovementDate { get; set; } = DateTime.Now;
    }
}
