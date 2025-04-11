using Core.Models;

namespace Application.DTO
{
    public class RecipeDTO
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Instructions { get; set; }

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}
