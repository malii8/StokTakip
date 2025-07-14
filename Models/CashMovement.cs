using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StokTakip.Models
{
    [Table("CashMovements")]
    public class CashMovement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string MovementType { get; set; } = string.Empty; // Gelir, Gider

        [Required]
        [StringLength(20)]
        public string PaymentMethod { get; set; } = "Nakit"; // Nakit, Kredi Kartı, Havale

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; } = string.Empty;

        [StringLength(50)]
        public string? DocumentNumber { get; set; }

        [ForeignKey("SalesReceipt")]
        public int? SalesReceiptId { get; set; }
        public virtual SalesReceipt? SalesReceipt { get; set; }

        [StringLength(50)]
        public string UserName { get; set; } = "Admin";

        [StringLength(500)]
        public string? Notes { get; set; }

        public DateTime MovementDate { get; set; } = DateTime.Now;
    }
}
