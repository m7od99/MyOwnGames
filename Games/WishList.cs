using System.Collections.Generic;
using System.Linq;
using System;
namespace MyOwnGames
{
  public class WishList
  {
    private List<Game> _games { get; set; }
    public WishList()
    {
      _games = new List<Game>();
    }
    public void AddGame(params Game[] games)
    {
      foreach (var game in games)
      {
        _games.Add(game);
      }
    }
    public void RemoveGame(Game game)
    {
      _games.Remove(game);
    }
    public void Clear()
    {
      _games.Clear();
    }
    public override string ToString()
    {
      return string.Join(Environment.NewLine, _games);
    }
  }
}