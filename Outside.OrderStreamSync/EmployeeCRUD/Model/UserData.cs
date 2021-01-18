using System;
using System.Collections.Generic;
using System.Text;

namespace Outside.OrderStreamSync.EmployeeCRUD.Model
{
  public  class UserData
    {
        public string EmailID { get; set; }
        public string Password { get; set; }

        public UserData()
        {
        }
        public UserData(string emailID, string password)
        {

            EmailID = emailID;
            Password = password;

        }
    }
}
