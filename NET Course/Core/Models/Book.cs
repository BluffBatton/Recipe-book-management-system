﻿namespace Core.Models
{
    public class Book
    {
        public int BookID { get; set; }

        public string? Title { get; set; }

        public string? Author { get; set; }

        public string? Description { get; set; }

        public List<Recipe> Recipes { get; set; } = new List<Recipe>();
    }
}
