﻿using System;
using System.ComponentModel.DataAnnotations;

namespace KaVoo.Models
{
    public class AdministrationModel
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public string Value { get; set; }
    }
}