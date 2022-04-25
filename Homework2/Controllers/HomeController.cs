using Homework2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string? sortOrder = null,string? currentSortOrder = null)
        {
            var newSortOrder = currentSortOrder != null 
                && currentSortOrder == sortOrder 
                && !currentSortOrder.Contains("_desc") ? sortOrder + "_desc" : sortOrder;

            var sortDir = newSortOrder != null && newSortOrder.Contains("_desc") ? "DESC" : "ASC";

            ViewData["CurrentSortOrder"] = newSortOrder;
            
            Contacts contacts = new Contacts();

            return View(contacts.GetContacts(sortOrder,sortDir));
        }
    }
}