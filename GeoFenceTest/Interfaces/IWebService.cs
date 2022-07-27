using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFenceTest.Interfaces
{
    public interface IWebService<T> where T : class
    {
        public Task<T> SearchForAddress(string address);
    }
}
