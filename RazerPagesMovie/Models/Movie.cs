﻿using System.ComponentModel.DataAnnotations;

namespace RazerPagesMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public decimal Price { get; set; }


    }
}
