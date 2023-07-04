using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class employee
    {
        [Key]
        public int Id { get; set; }

        public int EmployeeId { get; set; }     
    }
}
