using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Crud.Models
{
    public class orders
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrdersId { get; set; }

        [ForeignKey(nameof(customer))]
        public int CustomerId { get; set; }
        public string? OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public string? RequiredDate { get; set; }
        public string? ShippedDate { get; set;}

        [ForeignKey(nameof(stores))]
        public int StoreId { get; set; }

        [ForeignKey(nameof(staffs))]
        public int StaffId { get; set; }
        public customers customer { get; set; }
        public stores stores { get; set; }
        public staffs staffs { get; set;}
        public order_items order_Items { get; set; }
    }
}
