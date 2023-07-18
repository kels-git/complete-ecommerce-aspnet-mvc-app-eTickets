using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Producer Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name ="Producer Name")]
        public string FullName { get; set; }

        [Display(Name ="Bio")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set;}
    }
}
