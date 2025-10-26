using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HisVisionHCS.Web.Models;

namespace HisVisionHCS.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["Title"] = "Home - Updated " + DateTime.Now.ToString("HH:mm:ss");
        return View();
    }

    public IActionResult About()
    {
        ViewData["Title"] = "About Us";
        return View();
    }

    public IActionResult Services()
    {
        ViewData["Title"] = "Our Services";
        return View();
    }

    public IActionResult Careers()
    {
        ViewData["Title"] = "Careers";
        return View();
    }

    public IActionResult Referral()
    {
        ViewData["Title"] = "Referral";
        return View();
    }

    public IActionResult Contact()
    {
        ViewData["Title"] = "Contact Us";
        return View();
    }

    public IActionResult Privacy()
    {
        ViewData["Title"] = "Privacy Policy";
        return View();
    }

    public IActionResult Employees()
    {
        ViewData["Title"] = "Employee Forms";
        return View();
    }

    public IActionResult Test()
    {
        return Content("Test page is working!");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
