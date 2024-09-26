using Microsoft.AspNetCore.Mvc;

namespace GitDemoVST.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
