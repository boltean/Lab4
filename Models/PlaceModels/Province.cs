using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Places.Models.PlaceModels
{
    public class Province
    {
        [Key]
        [StringLength (2)]
        public string  ProvinceCode { get; set; }
        [Required]
        [Display(Name = "Province")]
        public string  ProvinceName { get; set; }

       public List<City > Cities { get; set; }

    }
}