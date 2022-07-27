using GeoFenceTest.Interfaces;
using GeoFenceTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GeoFenceTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISearch _search;

        public HomeController(ILogger<HomeController> logger, ISearch search)
        {
            _logger = logger;
            _search = search;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
        public async Task<IActionResult> Map(ShopAddress address)
        {
          
           return View();
        }


        public async Task<string> Search(ShopAddress _address)
        {
            var res = await _search.SearchLocation(_address.Address);
            var response = $"{res.Response.View[0].Result[0].Location.NavigationPosition[0].Latitude.ToString().Replace(',','.')},{res.Response.View[0].Result[0].Location.NavigationPosition[0].Longitude.ToString().Replace(',', '.')}";
            return response;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}