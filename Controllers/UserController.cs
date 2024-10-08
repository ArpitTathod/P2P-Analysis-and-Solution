using Microsoft.AspNetCore.Mvc;

namespace P2Psample1.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public UserController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
       
        
        public IActionResult ContactFrom()
        {
            return View();
        }









        public IActionResult OilandGasSolution()
        {
            return View();
        }




        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Service()
        {
            return View();
        }
        public IActionResult EngineeringService()
        {
            return View();
        }
        public IActionResult CreativeService()
        {
            return View();
        }
        public IActionResult WebService()
        {
            return View();
        }
        public IActionResult DigitalService()
        {
            return View();
        }
        public IActionResult StaffingService()
        {
            return View();
        }
        public IActionResult Manufacture()
        {
            return View();
        }
        public IActionResult Careers()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }
      
        public IActionResult AVLCOMPANY()
        {
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }


        public IActionResult GeneralEngineering()
        {
            return View();
        }

        public IActionResult AgriculturalSolutions()
        {
            return View();
        }

       

        public IActionResult Error()
        {
            return View();
        }
    }
}
