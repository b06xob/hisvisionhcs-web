using Microsoft.AspNetCore.Mvc;
using HisVisionHCS.Web.Models;
using HisVisionHCS.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace HisVisionHCS.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly HisVisionDbContext? _context;

        public EmployeesController(HisVisionDbContext? context = null)
        {
            _context = context;
        }

        // GET: /employees
        public IActionResult Index()
        {
            try
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
            catch (Exception ex)
            {
                // Log the exception and return a simple view
                return View(new List<object>
                {
                    new { 
                        Id = 1, 
                        Name = "Member Weekly Community Engagement Document", 
                        Description = "Track member community engagement activities and outcomes",
                        Action = "CommunityEngagement",
                        Icon = "fas fa-users"
                    }
                });
            }
        }

        // GET: /employees/communityengagement
        public IActionResult CommunityEngagement()
        {
            try
            {
                var model = new CommunityEngagement();
                return View(model);
            }
            catch (Exception ex)
            {
                // Return a simple error view or redirect
                return View(new CommunityEngagement());
            }
        }

        // POST: /employees/communityengagement
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CommunityEngagement(CommunityEngagement model)
        {
            if (_context == null)
            {
                ModelState.AddModelError("", "Database connection is not available. Please contact the administrator.");
                return View(model);
            }

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
            if (_context == null)
            {
                return View(new List<CommunityEngagement>());
            }

            try
            {
                var engagements = await _context.CommunityEngagements
                    .OrderByDescending(e => e.CreatedAt)
                    .ToListAsync();

                return View(engagements);
            }
            catch (Exception ex)
            {
                return View(new List<CommunityEngagement>());
            }
        }

        // GET: /employees/communityengagement/details/{id}
        public async Task<IActionResult> CommunityEngagementDetails(int id)
        {
            if (_context == null)
            {
                return NotFound();
            }

            try
            {
                var engagement = await _context.CommunityEngagements
                    .FirstOrDefaultAsync(e => e.Id == id);

                if (engagement == null)
                {
                    return NotFound();
                }

                return View(engagement);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
    }
}
