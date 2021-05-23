using GameWeb.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWeb.Concrete
{
  class GameManager : IGameService
  {
    public void Add(Game game)
    {
      Console.WriteLine(game.Name + " oyunu tanımlandı");
    }

    public void AddMultiple(Game[] games)
    {
      foreach (Game game in games)
      {
        Add(game);
      }
    }

    public void Delete(Game game)
    {
      Console.WriteLine(game.Name + " oyunu silindi");
    }

    public void Update(Game game)
    {
      Console.WriteLine(game.Name + " oyunu güncellendi");
    }
  }
}
