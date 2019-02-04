using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test_Abb.Models
{
    public class ElectricMotor : Motor
    {

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Voltage (V)")]
        public decimal VoltageV { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Current (A)")]
        public decimal CurrentA { get; set; }

        public virtual ICollection<ElectricMeasure> ElectricMeasures { get; set; }
    }
}