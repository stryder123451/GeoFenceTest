using GeoFenceTest.Interfaces;
using GeoFenceTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFenceTest.ViewModels
{
    public class WebService : IWebService<Root>
    {
        public async Task<Root> SearchForAddress(string address)
        {
            HttpClient _tokenclient = new HttpClient();
            var _responseToken = await _tokenclient.GetStringAsync
                ($"https://geocoder.ls.hereapi.com/search/6.2/geocode.json?languages=ru-RU&maxresults=4&searchtext={address}&apiKey=G2p3pzehc9M9VETiKmeha2G6nWB7-oH5umsR33pXIfE");
            var _jsonResults = JsonConvert.DeserializeObject<Root>(_responseToken);
            return _jsonResults;
        }
    }
}
