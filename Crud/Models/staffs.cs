using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Crud.Models
{
    public class staffs
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffId { get; set; }
        public int StoreId { get; set; }
        public int managerId { get; set; }
        public string?  First_Name { get; set; }
        public string? Last_Name { get; set;}
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? active { get; set; }
        public ICollection<stores> stores { get; set; }
        public ICollection<orders> orders { get; set; }


    }
}
