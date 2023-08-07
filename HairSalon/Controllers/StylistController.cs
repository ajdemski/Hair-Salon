using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HairSalon.Controllers
{
    public class StylistController : Controller
    {
        private readonly HairSalonContext _context;

        public StylistController(HairSalonContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var stylists = _context.Stylists.ToList();
            return View(stylists);
        }

        // Add other actions like Create, Edit, Delete, etc. for managing stylists
    }
}
