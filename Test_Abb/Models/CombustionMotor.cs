using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test_Abb.Models
{
    public class CombustionMotor : Motor
    {

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Fuel consumtion per hour(l/h)")]
        public decimal FuelConsumption { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Max torque at (rpm)")]
        public decimal MaxTorque { get; set; }

        public virtual ICollection<CombustionMeasure> CombustionMeasures { get; set; }
    }
}