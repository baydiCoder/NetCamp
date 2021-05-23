using System;
using System.Collections.Generic;
using System.Text;

namespace GameWeb.Abstract
{
  interface IUserCheckService
  {
     bool CheckIfRealPerson(User user);
  }
}
