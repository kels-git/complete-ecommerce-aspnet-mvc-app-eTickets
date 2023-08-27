using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor : IEntityBase
    {

        [Key]
        public int Id { get; set; }

        [Display(Name ="Actor Picture")]
        [Required(ErrorMessage ="Actor picture is required!")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Actor Name")]
        [Required(ErrorMessage = "Actor complete name is required!")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Full Name must be between 3 and 50 chars!")]
        public string FullName { get; set; }

        [Display(Name = "Bio")]
        [Required(ErrorMessage = "Actor Bio is required!")]
        public string Bio { get; set; }

        //Relationships
        #nullable disable
        public List<Actor_Movie> Actors_Movies { get; set;}

    }
}
