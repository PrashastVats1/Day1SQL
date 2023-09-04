using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIAssignment.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [StringLength(100)]
        public string Director { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [StringLength(100)]
        public string Genre { get; set; }
        public double Rating { get; set; }
    }
}
