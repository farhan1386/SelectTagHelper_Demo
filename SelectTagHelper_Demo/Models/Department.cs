using System.ComponentModel.DataAnnotations;

namespace SelectTagHelper_Demo.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Department")]
        public string DepartmentName { get; set; }
    }
}
