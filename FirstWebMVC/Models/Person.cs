using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace FirstWebMVC.Controllers
{
    [Table("Person")]
    public class Person 
    {
        [Key]
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public DateTime BirthDay { get; set; }
    }
}