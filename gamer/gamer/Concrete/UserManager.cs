using GameWeb.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWeb.Concrete
{
  class UserManager : IUserService
  {
    private IUserCheckService userCheckService;
    private List<Game> games;

    public UserManager(IUserCheckService userCheckService)
    {
      this.userCheckService = userCheckService;
      this.games = new List<Game>();
    }

    public void Add(User user)
    {
      if (userCheckService.CheckIfRealPerson(user))
      {
        Console.WriteLine(user.UserName + " kullanıcı eklendi");
      }
      else
      {
        throw new Exception("Not a valid person");
      }
    }

    public void AddGames(User user, Game game)
    {
      this.games.Add(game);
      Console.WriteLine(user.UserName + " tarafından " +
      game.Name + " satın alındı.");
    }

    public void Delete(User user)
    {
      Console.WriteLine(user.UserName + " kullanıcı silindi");
    }

    public void GetGames(User user)
    {
      Console.WriteLine(user.UserName + " aldığı oyunlar");
      foreach (Game game in games)
      {
        Console.WriteLine(" * " + game.Name);
      }
    }

    public void Update(User user)
    {
      Console.WriteLine(user.UserName + " kullanıcı güncellendi");
    }
  }
}
