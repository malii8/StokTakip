using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StokTakip.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string BarcodeNo { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [StringLength(50)]
        public string? StockCode { get; set; }

        [ForeignKey("ProductGroup")]
        public int? ProductGroupId { get; set; }
        public virtual ProductGroup? ProductGroup { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PurchasePrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal SalePrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal CurrentStock { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal MinimumStock { get; set; }

        [StringLength(20)]
        public string Unit { get; set; } = "Adet";

        [Column(TypeName = "decimal(5,2)")]
        public decimal VatRate { get; set; } = 10;

        [StringLength(500)]
        public string? Notes { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }

        // Navigation properties
        public virtual ICollection<SalesReceiptDetail> SalesReceiptDetails { get; set; } = new List<SalesReceiptDetail>();
        public virtual ICollection<StockMovement> StockMovements { get; set; } = new List<StockMovement>();
    }
}
