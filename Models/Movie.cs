﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vada.Models
{
    public class Movie
    {
        public int Id { get; set; }

     
        [StringLength(255)]
        public string Name { get; set; }

   
        public Genre Genre { get; set; }
    
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}