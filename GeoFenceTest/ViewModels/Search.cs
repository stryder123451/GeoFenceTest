using GeoFenceTest.Interfaces;
using GeoFenceTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFenceTest.ViewModels
{
    public class Search : ISearch
    {
        private readonly IWebService<Root> _webService;
        public Search(IWebService<Root> webService)=> _webService = webService;
        public async Task<Root> SearchLocation(string address)
        {
            var res = await _webService.SearchForAddress(address);
            if (res != null)
            {
                return res;
            }
            else
            {
                return null;
            }
        }

    }
}
