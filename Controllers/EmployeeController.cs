using Microsoft.AspNetCore.Mvc;
using Basics.Models;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            string message = $"Hello World. {DateTime.Now.ToString()}";
            return View("Index1", message);
        }

        public ViewResult Index2()
        {
            var names = new string[]
            {
                "Murat",
                "Melih",
                "Dilruba"
            };
            //View Result
            return View(names);
        }
        //IActionResult Content ve View gibi çeşitli değerleri tutabilir.
        public IActionResult Index3()
        {
            var list = new List<Employee>(){
                new Employee(){Id=1, FirstName="Murat",LastName="İpek",Age = 25},
                new Employee(){Id=2, FirstName="Melih",LastName="İpek",Age = 22},
                new Employee(){Id=3, FirstName="Dilruba",LastName="İpek",Age = 28}
            };
            //Content Result
            return View("Index3",list);
        }
    }
}