using Microsoft.AspNetCore.Mvc;
using HisVisionHCS.Web.Models;
using HisVisionHCS.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace HisVisionHCS.Web.Controllers
{
    public class FormsController : Controller
    {
        private readonly ILogger<FormsController> _logger;
        private readonly HisVisionDbContext _context;

        public FormsController(ILogger<FormsController> logger, HisVisionDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // GET: /forms/communityengagement
        public IActionResult CommunityEngagement()
        {
            ViewData["Title"] = "Community Engagement Form";
            var model = new CommunityEngagement();
            return View(model);
        }

        // POST: /forms/communityengagement
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CommunityEngagement(CommunityEngagement model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.CreatedAt = DateTime.Now;
                    model.Status = "Submitted";
                    _context.CommunityEngagements.Add(model);
                    await _context.SaveChangesAsync();

                    TempData["SuccessMessage"] = "Community engagement form submitted successfully!";
                    return RedirectToAction(nameof(CommunityEngagement));
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error saving Community Engagement form");
                    ModelState.AddModelError("", "An error occurred while saving the form. Please try again.");
                }
            }

            ViewData["Title"] = "Community Engagement Form";
            return View(model);
        }

        // GET: /forms/communityengagement/list
        public async Task<IActionResult> CommunityEngagementList()
        {
            ViewData["Title"] = "Community Engagement Forms";
            var forms = await _context.CommunityEngagements
                .OrderByDescending(f => f.CreatedAt)
                .ToListAsync();
            return View(forms);
        }
    }
}
