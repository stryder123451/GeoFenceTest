using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFenceTest.Models
{
    public class MatchQuality
    {
        public double County { get; set; }
        public double City { get; set; }
        public List<double> Street { get; set; }
        public double HouseNumber { get; set; }
    }
}
