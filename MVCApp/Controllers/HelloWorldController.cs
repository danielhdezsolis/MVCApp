using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int nunTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = nunTimes;
            return View();
        
        }
        //public string Index() 
        //{
        //    return "This is my default action...";
        //}

        ////Get: /HelloWorld/Welcome/
        ////Requieres using System.Text.Encodings.Web
        //public string Welcome(string name, int numTimes = 1) 
        //{
        //    //return "This is the welcome action method";
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");

        //}
    }
}
