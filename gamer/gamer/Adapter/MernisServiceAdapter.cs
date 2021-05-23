using GameWeb.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWeb.Adapter
{
  class MernisServiceAdapter:IUserCheckService
  {
   public  bool CheckIfRealPerson(User user)
    {


			KPS client = new KPS();
			bool result;

			result=client.TCDogrula(user.FirstName, user.LastName, user.DateOfBirth.Year.ToString());
				
		

			Console.WriteLine("Kimlik doğrulama : " + (result ? "başarılı" : "başarısız"));
			return result;
		}
  }
}

class KPS
{
	public bool TCDogrula(string firstName, string lastName, string year)
	{
    if (year.Contains("19"))
    {
			return true;
    }
		return false;
	}
}