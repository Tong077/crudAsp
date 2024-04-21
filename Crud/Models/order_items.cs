using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Crud.Models
{
    public class order_items
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Order_itemId { get; set; }

        [ForeignKey(nameof(orders))]
        public int OrderId { get; set; }
        public string? ItemId { get; set; }
        public string? ProductId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Price { get; set; }
        public string? Discount { get; set; }
        public products products { get; set; }
        public orders orders { get; set; }
    }
}
