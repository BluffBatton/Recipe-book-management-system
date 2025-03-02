namespace Core.Models
{
    public class Recipe
    {
        public string ?Title { get; set; }
        public string ?Instructions { get; set; }
        private List<Ingredient> ingredients { get; set; } = new List<Ingredient>();

        public List<Ingredient> GetIngredients()
        {
            return new List<Ingredient>(ingredients);
        }
        public void AddIngredient(Ingredient ingredient)
        {
            ingredients.Add(ingredient);
        }
        public void DeleteIngredient(Ingredient ingredient)
        {
            ingredients.Remove(ingredient);
        }
    }
}
