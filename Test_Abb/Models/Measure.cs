using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test_Abb.Models
{
    public abstract class Measure
    {
        public int MeasureId { get; set; }

        public int MotorId { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = @"{0:hh\:mm\:ss}", ApplyFormatInEditMode = true)]
       
        [Display(Name = "TimeStamp")]

        public TimeSpan Timestamp { get; set; }

       

    }
}