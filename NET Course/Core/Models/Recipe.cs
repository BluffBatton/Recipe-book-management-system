using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    internal class Recipe
    {
        public string ?Title { get; set; }
        public string ?Instructions { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}
