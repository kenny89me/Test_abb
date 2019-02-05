using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test_Abb.Models
{
    public class HydraulicMeasure : Measure
    {

        [Required]
        [Display(Name = "Actual pressure (bar)")]
        public decimal ActualPresureBar { get; set; }

        [Required]
        [Display(Name = "Difference (bar)")]
        public decimal? DifferenceBar { get; set; }

        public HydraulicMotor HydraulicMotor { get; set; }
    }
}