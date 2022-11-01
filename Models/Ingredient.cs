using fall22_PostIt_CSharp.Interfaces;

namespace AllSpice.Models;

public class Ingredient : ICreated, IRepoItem<int>
{
  public string name { get; set; }
  public string quantity { get; set; }
  public string recipeId { get; set; }
  public string CreatorId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  public Profile Creator { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  public DateTime UpdatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}