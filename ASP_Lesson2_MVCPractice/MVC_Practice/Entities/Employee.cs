using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Practice.Entities
{
    public class Employee
    {
        [Range(1,20)]
        public int Id { get; set; }
        public int CityId { get; set; }

        [Required]
        [DisplayName("User name")]
        public string Firstname { get; set; }

        [Required]
        [DisplayName("User surname")]
        public string Lastname { get; set; }
    }
}
