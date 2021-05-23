using System;
using System.Collections.Generic;
using System.Text;

namespace GameWeb.Abstract
{
  interface IUserService
  {
    void Add(User user);

    void Update(User user);

    void Delete(User user);

    void GetGames(User user);

    void AddGames(User user, Game game);
  }
}
