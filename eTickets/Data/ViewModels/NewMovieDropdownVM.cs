using eTickets.Models;

namespace eTickets.Data.ViewModels
{
    public class NewMovieDropdownVM
    {

        public NewMovieDropdownVM()
        {
            ProducersList = new List<Producer>();
            CinemasList = new List<Cinema>();
            ActorssList = new List<Actor>();
        }
        public List<Producer> ProducersList { get; set; }
        public List<Cinema> CinemasList { get; set; }
        public List<Actor> ActorssList { get; set; }
    }
}
