using System.Collections.Generic;
using Vada.Models;

namespace Vada.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
        public string Title
        {
            get
            {
                if (Movie != null && Movie.Id != 0)
                    return "Update Movie";

                return "Add Movie";
            }
        }
    }
}