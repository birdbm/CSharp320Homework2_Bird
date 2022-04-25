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
            
            ViewData["CurrentSortOrder"] = newSortOrder;
            
            Contacts contacts = new Contacts();

            return View(contacts.GetContacts(newSortOrder));
        }
    }
}