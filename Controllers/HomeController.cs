using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HisVisionHCS.Web.Models;
using HisVisionHCS.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace HisVisionHCS.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly HisVisionDbContext _context;

    public HomeController(ILogger<HomeController> logger, HisVisionDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
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

    // GET: /employees/communityengagement
    public IActionResult CommunityEngagement()
    {
        ViewData["Title"] = "Community Engagement Form";
        var model = new CommunityEngagement();
        return View(model);
    }

    // POST: /employees/communityengagement
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CommunityEngagement(CommunityEngagement model)
    {
        if (ModelState.IsValid)
        {
            try
            {
                model.CreatedAt = DateTime.Now;
                _context.CommunityEngagements.Add(model);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Community engagement form submitted successfully!";
                return RedirectToAction(nameof(CommunityEngagement));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "An error occurred while saving the form. Please try again.");
            }
        }

        ViewData["Title"] = "Community Engagement Form";
        return View(model);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
