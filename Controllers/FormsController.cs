using Microsoft.AspNetCore.Mvc;

namespace HisVisionHCS.Web.Controllers
{
    public class FormsController : Controller
    {
        private readonly ILogger<FormsController> _logger;

        public FormsController(ILogger<FormsController> logger)
        {
            _logger = logger;
        }

        // GET: /employees
        public IActionResult Index()
        {
            ViewData["Title"] = "Employee Forms";
            return View();
        }
    }
}
