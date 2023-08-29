using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppPartialViewAssignment
{
    [Table("Team")]
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        [Required]
        [StringLength(50)]
        public string TeamName { get; set; }
        [Required]
        public int NOWC { get; set; }
    }
}