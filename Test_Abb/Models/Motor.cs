using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Test_Abb.Models
{
    public enum MotorType
    {
        Electric, Combustion, Hydraulic
    }

    public abstract class Motor
    {
        [Key]
        public int MotorId { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Motor Name")]
        public string MotorName { get; set; }

        public MotorType? MotorType { get; set; }

        [Required]
        [Display(Name = "Max Power (kW)")]
        public decimal MaxPower { get; set; }

        public ICollection<Measure> Measures { get; set; }

    }
}