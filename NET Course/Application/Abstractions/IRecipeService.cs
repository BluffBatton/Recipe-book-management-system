using Core.Models;
namespace Application.Abstractions
{
    public interface IRecipeService
    {
        void CreateRecipe(Recipe recipe);
        IEnumerable<Recipe> GetAllRecipes();
        Recipe ReadRecipe(string title);
        void UpdateRecipe(Recipe recipe);
        void DeleteRecipe(Recipe recipe);
    }
}
//IEnumerable<Recipe> ReadAllRecipes();