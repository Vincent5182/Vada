using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Vada.Models;

namespace Vada.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public int? Id { get; set; }

        [Required(ErrorMessage = "Enter the movie name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "A genre is required")]
        public byte? GenreId { get; set; }

        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "The movie release date is required")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required(ErrorMessage = "Store requires 1 - 20 DVDs")]
        public byte? NumberInStock { get; set; }
        public string Title

        {

            get

            {

                return Id != 0 ? "Update Movie" : "Add Movie";


            }

        }




        public MovieFormViewModel()

        {

            Id = 0;

        }




        public MovieFormViewModel(Movie movie)

        {

            Id = movie.Id;

            Name = movie.Name;

            ReleaseDate = movie.ReleaseDate;

            NumberInStock = movie.NumberInStock;

            GenreId = movie.GenreId;

        }

    }

}