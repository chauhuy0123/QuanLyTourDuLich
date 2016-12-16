using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class VietNamCities
    {
        public static List<City> getAllCities()
        {
            string json = System.IO.File.ReadAllText("vn_cities.json");

            var cities = JsonConvert.DeserializeObject<List<City>>(json);
            cities.Sort();
            return cities;

        }
        public class City : IComparable<City>
        {
            public string name { get; set; }

            public int CompareTo(City other)
            {
               return name.CompareTo(other.name);
            }
        }

    }
}
