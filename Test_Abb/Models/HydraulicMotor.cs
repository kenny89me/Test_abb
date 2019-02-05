using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test_Abb.Models
{
    public class HydraulicMotor : Motor
    {

        [Required]
        
        [Display(Name = "Max presure (bar)")]
        public decimal MaxPresure { get; set; }

        [Required]
        
        [Display(Name = "Displacement (cm3/rev)")]
        public decimal Displacement { get; set; }

        public virtual ICollection<HydraulicMeasure> HydraulicMeasures { get; set; }
    }
}