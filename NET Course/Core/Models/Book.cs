namespace Core.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        private List<Recipe> recipes { get; set; } = new List<Recipe>();

        public List<Recipe> GetRecipes()
        {
            return new List<Recipe>(recipes);
        }
        public void AddRecipe(Recipe Recipe)
        {
            recipes.Add(Recipe);
        }
        public void DeleteRecipe(Recipe Recipe)
        {
            recipes.Remove(Recipe);
        }
    }
}
