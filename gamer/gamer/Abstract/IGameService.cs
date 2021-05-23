using System;
using System.Collections.Generic;
using System.Text;

namespace GameWeb.Abstract
{
  interface IGameService
  {
    void Add(Game game);

    void Update(Game game);

    void Delete(Game game);

    void AddMultiple(Game[] games);
  }
}
