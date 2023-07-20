using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;  
        }

        public async Task<IActionResult> Index()
        {
            var allActors = await _service.GetAll();
            return View(allActors);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(actor);
                }
                _service.Add(actor);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                Console.WriteLine($"Error occurred while saving entity changes: {ex}");

                // Add a custom error message to the ModelState to display on the View
                ModelState.AddModelError("", "An error occurred while saving data. Please try again.");

                // Return the View with the actor model to display validation errors and the custom error message
                return View(actor);
            }
        }
    }
}
