namespace Core.Models
{
    public class Recipe
    {
        public int RecipeID { get; set; }

        public string? Title { get; set; }

        public string? Instructions { get; set; }
        
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}
