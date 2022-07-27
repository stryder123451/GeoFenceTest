using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFenceTest.Models
{
    public class Response
    {
        public MetaInfo MetaInfo { get; set; }
        public List<View> View { get; set; }
    }
}
