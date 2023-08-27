using eTickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; } // identifier

        [Display(Name = "Cinema Logo")]
        [Required(ErrorMessage = "Cinema picture is required!")]
        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Cinema name is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Cinema name must be between 3 and 50 chars!")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required!")]
        public string Description { get; set; }

        // Relationships
        #nullable disable
        public List<Movie> Movies { get; set; }
    }
}






