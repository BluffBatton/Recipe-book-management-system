using Application.Abstractions;
using Core.Models;

namespace Infrastructure.Services
{
    public class RecipeService : IRecipeService
    {
        public async Task CreateRecipe(Recipe recipe)
        {
            await Task.CompletedTask;
        }

        public async Task DeleteRecipe(int RecipeID)
        {
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Recipe>> GetAllRecipes()
        {
            return await Task.FromResult(new List<Recipe>());
        }

        public async Task<Recipe> ReadRecipe(string title)
        {
            return await Task.FromResult(new Recipe());
        }

        public async Task UpdateRecipe(Recipe recipe)
        {
            await Task.CompletedTask;
        }
    }
}
