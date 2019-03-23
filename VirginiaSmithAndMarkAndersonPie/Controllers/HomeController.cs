using Microsoft.AspNetCore.Mvc;
using System.Linq;
using VirginiaSmithAndMarkAndersonPie.Models;
using VirginiaSmithAndMarkAndersonPie.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VirginiaSmithAndMarkAndersonPie.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Virginia Smith and Mark Andersons Pie Shop",
                Pies = pies.ToList()
            };

            return View(homeViewModel);
        }

        //Checks to see if the pie exists in the pieRepository and then returns it if it does.
        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
            {
                return NotFound();
            }

            return View(pie);
        }
    }
}