using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HisVisionHCS.Web.Data;
using HisVisionHCS.Web.Models;

namespace HisVisionHCS.Web.Controllers
{
    public class FormsController : Controller
    {
        private readonly HisVisionDbContext _context;

        public FormsController(HisVisionDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitReferral(Referral referral)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    referral.CreatedDate = DateTime.UtcNow;
                    referral.Status = "New";

                    _context.Referrals.Add(referral);
                    await _context.SaveChangesAsync();

                    TempData["SuccessMessage"] = "Thank you! Your referral has been submitted successfully. We will contact you soon.";
                    return Json(new { success = true, message = "Referral submitted successfully!" });
                }

                return Json(new { success = false, message = "Please check your form for errors." });
            }
            catch (Exception ex)
            {
                // Log the error (in production, use proper logging)
                return Json(new { success = false, message = "An error occurred. Please try again later." });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitCareerApplication(CareerApplication application)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    application.CreatedDate = DateTime.UtcNow;
                    application.Status = "New";

                    _context.CareerApplications.Add(application);
                    await _context.SaveChangesAsync();

                    TempData["SuccessMessage"] = "Thank you! Your application has been submitted successfully. We will review it and contact you soon.";
                    return Json(new { success = true, message = "Application submitted successfully!" });
                }

                return Json(new { success = false, message = "Please check your form for errors." });
            }
            catch (Exception ex)
            {
                // Log the error (in production, use proper logging)
                return Json(new { success = false, message = "An error occurred. Please try again later." });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitContactMessage(ContactMessage contactMessage)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contactMessage.CreatedDate = DateTime.UtcNow;
                    contactMessage.Status = "New";

                    _context.ContactMessages.Add(contactMessage);
                    await _context.SaveChangesAsync();

                    TempData["SuccessMessage"] = "Thank you! Your message has been sent successfully. We will respond to you soon.";
                    return Json(new { success = true, message = "Message sent successfully!" });
                }

                return Json(new { success = false, message = "Please check your form for errors." });
            }
            catch (Exception ex)
            {
                // Log the error (in production, use proper logging)
                return Json(new { success = false, message = "An error occurred. Please try again later." });
            }
        }
    }
}
