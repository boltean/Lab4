using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Places.Models.PlaceModels
{
    public class City
    {

        public int CityId { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "City")]
        public string CityName { get; set; }

        public int Population { get; set; }
        [Required]
        public string ProvinceCode { get; set; }

        public Province Province { get; set; }
    }
}