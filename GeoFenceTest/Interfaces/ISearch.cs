using GeoFenceTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFenceTest.Interfaces
{
    public interface ISearch
    {
        public Task<Root> SearchLocation(string address);
    }
}
