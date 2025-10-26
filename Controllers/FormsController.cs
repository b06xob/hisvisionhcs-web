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

        // Future form actions will go here
        // GET: /forms/communityengagement
        // GET: /forms/incidentreport
        // etc.
    }
}
