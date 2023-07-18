using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {

        [Key]
        public int ActorId { get; set; }

        [Display(Name ="Actor Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Actor Name")]
        public string FullName { get; set; }

        [Display(Name = "Bio")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set;}

    }
}
