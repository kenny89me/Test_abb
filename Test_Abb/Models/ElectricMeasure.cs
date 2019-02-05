using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test_Abb.Models
{
    public class ElectricMeasure : Measure
    {

        [Required]
        [Display(Name = "Actual current (A)")]
        public decimal ActualCurrentA { get; set; }

        [Required]
        [Display(Name = "Difference (A)")]
        public decimal? DifferenceA { get; set; }

        public virtual ElectricMotor ElectricMotor { get; set; }
    }
    

}