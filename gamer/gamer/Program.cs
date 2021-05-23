using GameWeb.Adapter;
using GameWeb.Concrete;
using System;

namespace GameWeb
{
  class Program
  {
    static void Main(string[] args)
    {
			UserManager userManager = new UserManager(new MernisServiceAdapter());
			User userElif = new User(1, "bilcom87", "123456",
					"elif", "baydi",new DateTime(1900,1,1) , "12345678990");
			userManager.Add(userElif);

			Console.WriteLine();
			GameManager gameManager = new GameManager();
			Game gameAsphalt = new Game(1, "Asphalt", 20);
			Game gameGta = new Game(1, "GTA", 10.75);
			Game gameSims = new Game(1, "Sims", 25.50);
			gameManager.AddMultiple(new Game[] { gameAsphalt, gameGta, gameSims });

			Console.WriteLine();
			DiscountManager discountManager = new DiscountManager();
			Discount discountSpring = new Discount("Bahar", 10, new DateTime(2021, 7,15));
			Discount discountWinter = new Discount("Ara Tatil", 10, new DateTime(2021, 1, 15));
			discountManager.Add(discountSpring);
			discountManager.Add(discountWinter);
			Console.WriteLine(); 
			
			SalesManager salesManager = new SalesManager(userManager, discountManager);
			salesManager.Sold(gameGta, userElif);
			salesManager.Sold(gameSims, userElif, discountSpring);
			salesManager.Sold(gameAsphalt, userElif, discountWinter);
      Console.WriteLine();
			userManager.GetGames(userElif);

      Console.ReadLine();
		}
  }
}
