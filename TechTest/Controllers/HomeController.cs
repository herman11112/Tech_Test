using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TechTest.Models;

namespace TechTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        private readonly Fruit fruit = new Fruit();
        private readonly Veggies veggies = new Veggies();
        public List<Profiles> finalResult = new List<Profiles>();

        public IActionResult Index()
        {

            var result = _context.ExecuteQuery();
            var result2 = _context.ExecuteQueryMin();
            finalResult.AddRange(result);
            finalResult.AddRange(result2);
            MyViewModel viewModel = new MyViewModel
            {

                profileList = finalResult,
                fruitList = fruit.getName(),
                veggiesList = veggies.getName()
            };
            return View(viewModel);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}