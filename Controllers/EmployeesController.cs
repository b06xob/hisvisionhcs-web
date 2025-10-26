using Microsoft.AspNetCore.Mvc;
using HisVisionHCS.Web.Models;
using HisVisionHCS.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace HisVisionHCS.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly HisVisionDbContext _context;

        public EmployeesController(HisVisionDbContext context)
        {
            _context = context;
        }

        // GET: /employees
        public IActionResult Index()
        {
            var forms = new List<object>
            {
                new { 
                    Id = 1, 
                    Name = "Member Weekly Community Engagement Document", 
                    Description = "Track member community engagement activities and outcomes",
                    Action = "CommunityEngagement",
                    Icon = "fas fa-users"
                }
                // Add more forms here as needed
            };

            return View(forms);
        }

        // GET: /employees/communityengagement
        public IActionResult CommunityEngagement()
        {
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
                    // Log the exception here if needed
                }
            }

            return View(model);
        }

        // GET: /employees/communityengagement/list
        public async Task<IActionResult> CommunityEngagementList()
        {
            var engagements = await _context.CommunityEngagements
                .OrderByDescending(e => e.CreatedAt)
                .ToListAsync();

            return View(engagements);
        }

        // GET: /employees/communityengagement/details/{id}
        public async Task<IActionResult> CommunityEngagementDetails(int id)
        {
            var engagement = await _context.CommunityEngagements
                .FirstOrDefaultAsync(e => e.Id == id);

            if (engagement == null)
            {
                return NotFound();
            }

            return View(engagement);
        }
    }
}
