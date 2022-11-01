namespace AllSpice.Services;

public class RecipesService
{
  private readonly RecipeRepository _repo;

  public RecipesService(RecipeRepository repo)
  {
    _repo = repo;
  }

  internal Recipe CreateRecipe(Recipe newRecipe)
  {
    return _repo.CreateRecipe(newRecipe);
  }
}