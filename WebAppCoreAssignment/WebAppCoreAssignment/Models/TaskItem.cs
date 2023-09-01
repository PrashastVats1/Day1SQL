using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppCoreAssignment.Models
{
    [Table("TaskItem")]
    public class TaskItem
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Due date is required")]
        public DateTime DueDate { get; set; }
    }
}
