using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace HairSalon.Controllers
{
    public class ClientsController : Controller
    {
        private readonly HairSalonContext _context;

        public ClientsController(HairSalonContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            var viewModel = new ClientCreateViewModel
            {
                Stylists = _context.Stylists
                    .Select(s => new SelectListItem { Value = s.StylistId.ToString(), Text = s.Name })
                    .ToList()
            };
            return View(viewModel);
        }

        // Other actions for the controller...

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ClientCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var client = new Client
                {
                    Name = viewModel.Name,
                    // Set other properties for the client
                    // e.g., viewModel.StylistId can be used to set the StylistId property
                };

                // Save the new client to the database.
                _context.Clients.Add(client);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            // If the model is not valid, return the view with validation errors.
            viewModel.Stylists = _context.Stylists
                .Select(s => new SelectListItem { Value = s.StylistId.ToString(), Text = s.Name })
                .ToList();
            return View(viewModel);
        }
    }
}
