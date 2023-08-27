using eTickets.Data.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Producer Picture")]
        [Required(ErrorMessage = "Producer picture is required!")]
        public string ProfilePictureURL { get; set; }

        [Display(Name ="Producer Name")]
        [Required(ErrorMessage = "Producer complete name is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars!")]
        public string FullName { get; set; }

        [Display(Name ="Bio")]
        [Required(ErrorMessage = "Actor Bio is required!")]
        public string Bio { get; set; }

        //Relationships
         #nullable disable
        public List<Movie> Movies { get; set;}
    }
}
