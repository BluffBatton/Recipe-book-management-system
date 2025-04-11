using Application.DTO;
using AutoMapper;
using Core.Models;

namespace Application.Mapping
{
    public class AppMappingProfile
    {
        public static Mapper InitializeAutomapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Book, BookDTO>().ReverseMap();
                cfg.CreateMap<Ingredient, IngredientDTO>().ReverseMap();
                cfg.CreateMap<Recipe, RecipeDTO>().ReverseMap();
                cfg.CreateMap<User, UserDTO>().ReverseMap();
            });
            var mapper = new Mapper(config);
            return mapper;
        }
    }
}