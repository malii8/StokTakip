using System.ComponentModel.DataAnnotations;

namespace StokTakip.Models
{
    public class QuickSaleButtonConfig
    {
        [Key]
        public int Id { get; set; }
        public int ButtonIndex { get; set; }
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? BarcodeNo { get; set; }

        // Navigation property
        public virtual Product Product { get; set; } = null!;
    }
}
