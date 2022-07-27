using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFenceTest.Models
{
    public class View
    {
        public string _type { get; set; }
        public int ViewId { get; set; }
        public List<Result> Result { get; set; }
    }
}
