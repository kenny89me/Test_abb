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
        [DataType(DataType.Currency)]
        [Display(Name = "Actual pressure (bar)")]
        public decimal ActualPresureBar { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Difference (bar)")]
        public decimal? DifferenceBar { get; set; }

        public virtual HydraulicMotor GetHydraulicMotor { get; set; }
    }
}