using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test_Abb.Models
{
    public class CombustionMeasure : Measure
    {

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Actual revs. (rpm)")]
        public decimal ActualRevsRpm { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Difference (rpm)")]
        public decimal? DifferenceRpm { get; set; }

        public virtual CombustionMotor CombustionMotor { get; set; }
    }
}