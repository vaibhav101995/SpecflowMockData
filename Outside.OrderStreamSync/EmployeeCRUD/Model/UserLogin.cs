using System;
using System.Collections.Generic;
using System.Text;

namespace Outside.OrderStreamSync.EmployeeCRUD.Model
{
  public  class UserLogin
    {
        public string EmailID { get; set; }
        public string Password { get; set; }
       
        public UserLogin()
        {
        }
        public UserLogin( string emailID, string password)
        {

            EmailID = emailID;
            Password = password;
            
        }
    }
}
