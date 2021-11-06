using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab04.Models
{
    public class Province
    {
        [Key]
        [Display(Name = "Province Code")]
        public string ProvinceCode { get; set; }
        
        [Display(Name = "Province Name")]
        public string ProvinceName { get; set; }
        public List<City> Cities { get; set; }

    }
}