namespace AllSpice.Models;

public class FavRecipe : Recipe
{
  public int FavoriteId { get; set; }
  public int recipeId { get; set; }
  public string AccountId { get; set; }
}
