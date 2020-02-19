using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataValidationsMVC.Models
{
    public class EmpClass
    {
        [Required]
        public int ID { get; set; }
        [Required(ErrorMessage ="Please, Enter the name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Enter Salary")]
        public decimal Salary { get; set; }
    }
}