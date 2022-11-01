
namespace AllSpice.Repositories;
public class RecipeRepository : BaseRepository
{
  public RecipeRepository(IDbConnection db) : base(db)
  {
  }

  internal Recipe CreateRecipe(Recipe newRecipe)
  {
    string sql = @"
    INSERT INTO recipes(title, instructions, img, category, creatorId)
    VALUES (@Title, @Instructions, @Img, @Category, @CreatorId);
    SELECT LAST_INSERT_ID()
    ;";

    int recipeId = _db.ExecuteScalar<int>(sql, newRecipe);
    newRecipe.Id = recipeId;
    return newRecipe;
  }

  internal Recipe GetById(int recipeId)
  {
    string sql = @"
    SELECT
    rec.*
    r.*
    FROM recipes rec
    JOIN accounts a ON r.id = rec.creatorId
    LEFT JOIN favorites fav ON fav.recipeId = rec.id
    WHERE rec.id = @recipeId
    ;";
    return _db.Query<Recipe, Profile, Recipe>(sql, (recipe, profile) =>
    {
      recipe.Creator = profile;
      return recipe;
    }, new { recipeId }).FirstOrDefault();
  }

  internal List<Recipe> GetAllRecipes()
  {
    string sql = @"
    SELECT
    rec.*
    r.*
    FROM recipes rec
    JOIN accounts r ON r.id = rec.creatorId
    ;";
    return _db.Query<Recipe, Profile, Recipe>(sql, (recipe, profile) =>
    {
      recipe.Creator = profile;
      return recipe;
    }).ToList();
  }

  internal void DeleteRecipe(Recipe foundRecipe)
  {
    string sql = @"
    DELETE FROM recipes
    WHERE id = @id
    ;";
    int rows = _db.Execute(sql, foundRecipe);
    if (rows == 0)
    {
      throw new Exception("Weird, the recipe is still here....");
    }
  }

  internal Recipe EditRecipe(Recipe recipeData)
  {
    string sql = @"
    UPDATE recipes SET
    instructions = @Instructions,
    title = @Title,
    category = @Category
    img = @img
    WHERE id = @Id
    ;";
    int row = _db.Execute(sql, recipeData);
    if (row == 0)
    {
      throw new Exception("Weird, the recipe stayed the same...");
    }

    return recipeData;
  }


}