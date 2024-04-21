using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Crud.Models
{
    public class stores
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StoreId { get; set; }
        public string? Store_Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zipcode { get; set; }
       
        public ICollection<orders> orders { get; set; }
        public stoks stoks { get; set; }
        public staffs staffs { get; set; }


    }
}
