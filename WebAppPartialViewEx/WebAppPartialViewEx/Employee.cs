using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppPartialViewEx
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Designation { get; set; }
        public double Salary { get; set; }
        public DateTime DOJ { get; set; }
    }
}