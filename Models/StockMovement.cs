using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StokTakip.Models
{
    [Table("StockMovements")]
    public class StockMovement
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string MovementType { get; set; } = string.Empty; // Giriş, Satış, İade, Sayım

        [Column(TypeName = "decimal(18,2)")]
        public decimal Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        [StringLength(50)]
        public string? DocumentNumber { get; set; }

        [StringLength(50)]
        public string? RelatedEntity { get; set; } // Toptancı adı, Müşteri adı vb.

        [ForeignKey("Wholesaler")]
        public int? WholesalerId { get; set; }
        public virtual Wholesaler? Wholesaler { get; set; }

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
