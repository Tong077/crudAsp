using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud.Models
{
    public class products
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        [ForeignKey(nameof(brands))]
        public int BrandId {  get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public string? ModelYear { get; set; }
        public string? Listprice { get; set; }
        public brands brands { get; set; }
        public Category categorys { get; set; }
        public ICollection<order_items> order_items { get; set; }
    }
}
