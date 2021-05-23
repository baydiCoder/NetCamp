using GameWeb.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWeb.Concrete
{
  class SalesManager:ISalesService
  {
		private IUserService userService;
		private IDiscountService discountService;

		public SalesManager(IUserService _userService)
		{
			this.userService = _userService;
		}

		public SalesManager(IUserService _userService, IDiscountService discountService)
		{
			this.discountService = discountService;
			this.userService = _userService;

		}

		 
	public void Sold(Game game, User user)
		{
		   userService.AddGames(user, game);
		}

		 
	public void Sold(Game game, User user, Discount discount)
		{

			if (discountService.Validate(discount))
			{
				game.Price=game.Price - (game.Price * discount.DiscountPercent);
				userService.AddGames(user, game);
			}
			else
        Console.WriteLine("Kampanya süresi dolmuştur.Satış işlemi gerçekleştirilemedi.");
		}

	}
}
