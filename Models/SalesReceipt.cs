using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StokTakip.Models
{
    [Table("SalesReceipts")]
    public class SalesReceipt
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string ReceiptNumber { get; set; } = string.Empty;

        public DateTime ReceiptDate { get; set; } = DateTime.Now;

        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

        [Required]
        [StringLength(20)]
        public string PaymentType { get; set; } = "Nakit"; // Nakit, Kredi Kartı, Havale, Veresiye

        [Column(TypeName = "decimal(18,2)")]
        public decimal SubTotal { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal VatAmount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Discount { get; set; } = 0;

        [StringLength(20)]
        public string Status { get; set; } = "Tamamlandı"; // Tamamlandı, İptal

        [StringLength(50)]
        public string CashierName { get; set; } = "Admin";

        [StringLength(500)]
        public string? Notes { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Navigation properties
        public virtual ICollection<SalesReceiptDetail> Details { get; set; } = new List<SalesReceiptDetail>();
    }
}
