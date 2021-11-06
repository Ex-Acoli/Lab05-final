using System.Collections.Generic;
using Lab04.Models;

namespace Lab04.Data
{
    public class SampleData
    {
        public static List<Province> GetProvinces(){
            List<Province> provinces = new List<Province>(){
                new Province(){
                    ProvinceCode = "AB",
                    ProvinceName = "Alberta"
                },
                new Province(){
                    ProvinceCode = "BC",
                    ProvinceName = "British Columbia"
                },
                new Province(){
                    ProvinceCode = "MB",
                    ProvinceName = "Manitoba"
                },
                new Province(){
                    ProvinceCode = "NB",
                    ProvinceName = "New Brunswick"
                },
                new Province(){
                    ProvinceCode = "NL",
                    ProvinceName = "Newfoundland"
                },
                new Province(){
                    ProvinceCode = "NS",
                    ProvinceName = "Nova Scotia"
                },
                new Province(){
                    ProvinceCode = "ON",
                    ProvinceName = "Ontario"
                },
                new Province(){
                    ProvinceCode = "PE",
                    ProvinceName = "Prince Edward Island"
                },
                new Province(){
                    ProvinceCode = "QC",
                    ProvinceName = "Quebec"
                },
                new Province(){
                    ProvinceCode = "SK",
                    ProvinceName = "Saskatchewan"
                }
            };

            return provinces;
        }

        public static List<City> GetCities() {
            List<City> cities = new List<City>(){
                new City(){
                    CityID = 1,
                    CityName = "Edmonton",
                    Population = 165121,
                    ProvinceCode = "AB"
                },
                new City(){
                    CityID = 2,
                    CityName = "Calgary",
                    Population = 135234,
                    ProvinceCode = "AB"
                },
                new City(){
                    CityID = 3,
                    CityName = "Victoria",
                    Population = 18951,
                    ProvinceCode = "BC"
                },
                new City(){
                    CityID = 4,
                    CityName = "Vancouver",
                    Population = 244895,
                    ProvinceCode = "BC"
                },
                new City(){
                    CityID = 5,
                    CityName = "Winnipeg",
                    Population = 83155,
                    ProvinceCode = "MB"
                },
                new City(){
                    CityID = 6,
                    CityName = "Fredericton",
                    Population = 18623,
                    ProvinceCode = "NB"
                },
                new City(){
                    CityID = 7,
                    CityName = "Moncton",
                    Population = 1816513,
                    ProvinceCode = "NB"
                },
                new City(){
                    CityID = 8,
                    CityName = "St.John's",
                    Population = 48913,
                    ProvinceCode = "NL"
                },
                new City(){
                    CityID = 9,
                    CityName = "Halifax",
                    Population = 498564,
                    ProvinceCode = "NS"
                },
                new City(){
                    CityID = 10,
                    CityName = "Toronto",
                    Population = 849156,
                    ProvinceCode = "ON"
                },
                new City(){
                    CityID = 11,
                    CityName = "Charlottetown",
                    Population = 198137,
                    ProvinceCode = "PE"
                },
                new City(){
                    CityID = 12,
                    CityName = "Quebec City",
                    Population = 908465,
                    ProvinceCode = "QC"
                },
                new City(){
                    CityID = 13,
                    CityName = "Regina",
                    Population = 4442879,
                    ProvinceCode = "SK"
                },
                new City(){
                    CityID = 14,
                    CityName = "Saskatoon",
                    Population = 716129,
                    ProvinceCode = "SK"
                }
            };

            return cities;
        }
    }
}