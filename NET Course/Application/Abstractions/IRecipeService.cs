using Core.Models;
namespace Application.Abstractions
{
    public interface IRecipeService
    {
        Task CreateRecipe(Recipe recipe);

        Task<IEnumerable<Recipe>> GetAllRecipes();

        Task<Recipe> ReadRecipe(string title);

        Task UpdateRecipe(Recipe recipe);

        Task DeleteRecipe(int RecipeID);
    }
}
