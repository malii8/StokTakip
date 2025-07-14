using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StokTakip.Models
{
    [Table("CustomerDebtMovements")]
    public class CustomerDebtMovement
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string MovementType { get; set; } = string.Empty; // Borç, Ödeme, İade

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [StringLength(50)]
        public string? DocumentNumber { get; set; }

        [ForeignKey("SalesReceipt")]
        public int? SalesReceiptId { get; set; }
        public virtual SalesReceipt? SalesReceipt { get; set; }

        [StringLength(200)]
        public string? Description { get; set; }

        [StringLength(50)]
        public string UserName { get; set; } = "Admin";

        public DateTime MovementDate { get; set; } = DateTime.Now;
    }
}
