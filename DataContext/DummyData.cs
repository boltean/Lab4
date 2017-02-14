using Places.Models;
using Places.Models.PlaceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Places.DataContext
{
    public class DummyData
    {

        public static System.Collections.Generic.List<Province> getProvinces()
        {
            List<Province> provinces = new List<Province>()
            {
                new Province(){
                   ProvinceCode="AB",
                   ProvinceName="Alberta"
                },
                new Province(){
                   ProvinceCode="BC",
                   ProvinceName="British Columbia"
                },
                new Province(){
                   ProvinceCode="ON",
                   ProvinceName="Ontario"
                }

            };

            return provinces;

        }

        public static List<City> getCities(ApplicationDbContext context)
        {
            List<City> cities = new List<City>() {
                new Models.PlaceModels.City {
                    CityName ="Calgary",
                    Population=1000000,
                    ProvinceCode=context.Provinces.Find("AB").ProvinceCode
                },
                 new Models.PlaceModels.City {
                    CityName ="Edmonton",
                    Population=1000000,
                    ProvinceCode=context.Provinces.Find("AB").ProvinceCode
                },
                  new Models.PlaceModels.City {
                    CityName ="Red Deer",
                    Population=200000,
                    ProvinceCode=context.Provinces.Find("AB").ProvinceCode
                },

                   new Models.PlaceModels.City {
                    CityName ="Vancouver",
                    Population=500000,
                    ProvinceCode=context.Provinces.Find("BC").ProvinceCode
                },
                    new Models.PlaceModels.City {
                    CityName ="Victoria",
                    Population=100000,
                    ProvinceCode=context.Provinces.Find("BC").ProvinceCode
                },
                     new Models.PlaceModels.City {
                    CityName ="Burnaby",
                    Population=150000,
                    ProvinceCode=context.Provinces.Find("BC").ProvinceCode
                },
                      new Models.PlaceModels.City {
                    CityName ="Toronto ",
                    Population=1500000,
                    ProvinceCode=context.Provinces.Find("ON").ProvinceCode
                },
                       new Models.PlaceModels.City {
                    CityName ="London",
                    Population=180000,
                    ProvinceCode=context.Provinces.Find("ON").ProvinceCode
                },
                        new Models.PlaceModels.City {
                    CityName ="Ottawa",
                    Population=300000,
                    ProvinceCode=context.Provinces.Find("ON").ProvinceCode
                }
            };
            return cities;

        }

    }
}