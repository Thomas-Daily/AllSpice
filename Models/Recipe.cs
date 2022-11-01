using fall22_PostIt_CSharp.Interfaces;

namespace AllSpice.Models;

public class Recipe : ICreated, IRepoItem<int>
{
  public string title { get; set; }
  public string instructions { get; set; }
  public string img { get; set; }
  public string category { get; set; }
  public string CreatorId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  public Profile Creator { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  public DateTime UpdatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}


