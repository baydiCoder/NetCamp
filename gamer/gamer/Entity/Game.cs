using System;
using System.Collections.Generic;
using System.Text;

namespace GameWeb
{
  class Game
  {
    public Game()
    { 
    }
    public Game(int gameId, String name, double price)
    {

      this.GameId = gameId;
      this.Name = name;
      this.Price = price;
    }

    public int GameId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
  }
}
