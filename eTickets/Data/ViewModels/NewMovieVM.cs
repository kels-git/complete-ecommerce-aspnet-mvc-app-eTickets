using eTickets.Data.Base;
using eTickets.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    [Keyless]
    public class NewMovieVM 
    {
        [Display(Name = "Movie name")]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }

        [Display(Name = "Price in RM")]
        [Required(ErrorMessage = "Price is Required")]
        public double Price { get; set; }

        [Display(Name = "Movie Poster URL")]
        [Required(ErrorMessage = "Movie Poster URL is Required")]
        public string ImageURL { get; set; }

        [Display(Name = "Movie Start Date")]
        [Required(ErrorMessage = "Start Date is Required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie End Date")]
        [Required(ErrorMessage = "End Date is Required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select Category")]
        [Required(ErrorMessage = "Movie Category is Required")]
        public MovieCategory MovieCategory { get; set; }

        [Display(Name = "Select Actor(s)")]
        [Required(ErrorMessage = "Movie Actor is Required")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Select Cinema(s)")]
        [Required(ErrorMessage = "Movie Cinema is Required")]
        public int CinemaId { get; set; }

        [Display(Name = "Select Producer(s)")]
        [Required(ErrorMessage = "Movie Producer is Required")]
        public int ProducerId { get; set; }
    }
}