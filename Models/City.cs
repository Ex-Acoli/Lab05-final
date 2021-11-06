using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab04.Models
{
    public class City
    {
        [Key]
        [Display(Name = "ID")]
        public int CityID { get; set; }
        
        [Display(Name = "City")]
        public string CityName { get; set; }
        public int Population { get; set; }
        
        [Display(Name = "Province Code")]
        public string ProvinceCode { get; set; }
        
        [ForeignKey("ProvinceCode")]
        [Display(Name = "Province Code")]
        public Province Province { get; set; }

    }
}