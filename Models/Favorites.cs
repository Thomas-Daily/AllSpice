using fall22_PostIt_CSharp.Interfaces;

namespace AllSpice.Models;

public class Favorites : IRepoItem<int>
{
  public string accountId { get; set; }
  public string recipeId { get; set; }
  public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  public DateTime UpdatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}