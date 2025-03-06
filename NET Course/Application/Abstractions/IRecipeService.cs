using Core.Models;
namespace Application.Abstractions
{
    public interface IRecipeService
    {
        void CreateRecipe(Recipe recipe, Ingredient ingredient);
        IEnumerable<Recipe> GetAllRecipes();
        Recipe ReadRecipe(string title);
        void UpdateRecipe(Recipe recipe, Ingredient ingredient);
        void DeleteRecipe(Recipe recipe);
    }
}
