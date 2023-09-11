using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            _service = service;
        }
     
        public async Task<IActionResult> Index()
        {
            var allMovies = await _service.GetAllAsync(n => n.Cinema);
            return View(allMovies);
        }
   
        //GET: Movies/Details/ID
        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _service.GetMovieByIdAsync(id);
            return View(movieDetail);
        }

        //GET: Movies/Create
        public async Task<IActionResult> Create()
        {
            var movieDropdownData = await _service.GetNewMovieDropdownVM();
            ViewBag.Cinemas = new SelectList(movieDropdownData.CinemasList, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownData.ProducersList, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdownData.ActorssList, "Id", "FullName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewMovieVM movie)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(movie);
                }
                await _service.AddNewMovieAsync(movie);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                Console.WriteLine($"Error occurred while saving entity changes: {ex}");

                // Add a custom error message to the ModelState to display on the View
                ModelState.AddModelError("", "An error occurred while saving data. Please try again.");

                // Return the View with the actor model to display validation errors and the custom error message
                return View(movie);
            }
        }
    }
}
