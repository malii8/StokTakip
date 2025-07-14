using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StokTakip.Models
{
    [Table("SalesReceiptDetails")]
    public class SalesReceiptDetail
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("SalesReceipt")]
        public int SalesReceiptId { get; set; }
        public virtual SalesReceipt SalesReceipt { get; set; } = null!;

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal VatRate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Discount { get; set; } = 0;

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
