using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud.Models
{
    public class stoks
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StockId { get; set; }

        [ForeignKey(nameof(stores))]
        public int StoreId { get; set; }

        [ForeignKey(nameof(products))]
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public stores stores { get; set; }
    }
}
