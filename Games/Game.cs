namespace MyOwnGames
{
  public class Game
  {
    private string Name { get; set; }

    public Game(string name)
    {
      Name = name;
    }
    public override string ToString()
    {
      return $"Name: {Name}";
    }
  }
  
}
