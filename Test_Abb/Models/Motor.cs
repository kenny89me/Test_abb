﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Test_Abb.Models
{
    public abstract class Motor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Motor Name")]
        public string MotorName { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Max Power (kW)")]
        public decimal MaxPower { get; set; }


        

    }
}