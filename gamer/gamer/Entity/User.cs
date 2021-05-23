using System;
using System.Collections.Generic;
using System.Text;

namespace GameWeb
{
  class User
  {
    public User()
    { }

      public User(int v1, string v2, string v3, string v4, string v5, DateTime date, string v6)
    {
      this.UserId = v1;
      this.UserName = v2;
      this.Password = v3;
      this.FirstName = v4;
      this.LastName = v5;
      this.DateOfBirth = date;
      this.NationalityId = v6;
    }

    public int UserId { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string NationalityId { get; set; }
  }
}
