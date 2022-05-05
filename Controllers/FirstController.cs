using Microsoft.AspNetCore.Mvc;

namespace firstWeb.Controllers
{
    public class FirstController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View("Index");
        }
        [HttpGet]
        [Route("second/{param}")]
        public string Second(string param)
        {
            return "This is a second page and my parameter is {param}";
        }
        [HttpGet("third")]
        public string Third()
        {
            return "This is my third page";
        }
    }
}