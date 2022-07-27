using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFenceTest.Models
{
    public class Location
    {
        public string LocationId { get; set; }
        public string LocationType { get; set; }
        public DisplayPosition DisplayPosition { get; set; }
        public List<NavigationPosition> NavigationPosition { get; set; }
        public MapView MapView { get; set; }
        public Address Address { get; set; }
    }
}
