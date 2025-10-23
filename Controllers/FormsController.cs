using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HisVisionHCS.Web.Data;
using HisVisionHCS.Web.Models;
using HisVisionHCS.Web.Services;

namespace HisVisionHCS.Web.Controllers
{
    public class FormsController : Controller
    {
        private readonly HisVisionDbContext _context;
        private readonly ICaptchaService _captchaService;

        public FormsController(HisVisionDbContext context, ICaptchaService captchaService)
        {
            _context = context;
            _captchaService = captchaService;
        }

        [HttpGet]
        public IActionResult GetCaptcha()
        {
            var captcha = _captchaService.GenerateQuestion();
            return Json(new { question = captcha.Question, answer = captcha.Answer });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitReferral(Referral referral, string captchaAnswer, int captchaExpectedAnswer)
        {
            try
            {
                // Validate captcha first
                if (!_captchaService.ValidateAnswer(captchaAnswer, captchaExpectedAnswer))
                {
                    return Json(new { success = false, message = "Please solve the security question correctly." });
                }

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
        public async Task<IActionResult> SubmitCareerApplication(CareerApplication application, string captchaAnswer, int captchaExpectedAnswer)
        {
            try
            {
                // Validate captcha first
                if (!_captchaService.ValidateAnswer(captchaAnswer, captchaExpectedAnswer))
                {
                    return Json(new { success = false, message = "Please solve the security question correctly." });
                }

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
        public async Task<IActionResult> SubmitContactMessage(ContactMessage contactMessage, string captchaAnswer, int captchaExpectedAnswer)
        {
            try
            {
                // Validate captcha first
                if (!_captchaService.ValidateAnswer(captchaAnswer, captchaExpectedAnswer))
                {
                    return Json(new { success = false, message = "Please solve the security question correctly." });
                }

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
