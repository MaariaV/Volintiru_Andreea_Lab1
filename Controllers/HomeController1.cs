using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Volintiru_Andreea_Lab1.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return Content("Ciao Maria");
        }
        public IActionResult Index2()
        {
            return Content("Bine ai venit");
        }

        public IActionResult Index3(string x,int n)
        {
            return Content("Valoarea generata pentru x este: negativa"+ x + ". Valoarea generata pentru n este: "+ n+ ".");
        }
    }
}









