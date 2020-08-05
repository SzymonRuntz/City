using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace city.Model
{
    public class CityOde
    {
        public int id { get; set; }
        public string name { get; set; }


        public IEnumerable<CityInfo> CityInfo { get; set; } = new List<CityInfo>();

    }
}
