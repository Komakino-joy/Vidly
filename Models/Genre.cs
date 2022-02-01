﻿using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}