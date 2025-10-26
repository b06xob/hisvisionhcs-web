using Microsoft.AspNetCore.Mvc;

namespace HisVisionHCS.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ILogger<EmployeesController> _logger;

        public EmployeesController(ILogger<EmployeesController> logger)
        {
            _logger = logger;
        }

        // GET: /employees
        public IActionResult Index()
        {
            ViewData["Title"] = "Employee Portal";
            return View();
        }
    }
}
