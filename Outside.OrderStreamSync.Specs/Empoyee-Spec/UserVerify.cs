using Outside.OrderStreamSync.EmployeeCRUD.Model;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;

namespace Outside.OrderStreamSync.Specs.Empoyee_Spec
{
  public  class UserVerify
    {
        public string EmailID { get; set; }
        public string Password { get; set; }
        public UserVerify(string emailID, string password)
        {

            EmailID = emailID;
            Password = password;

        }

        public bool Matches(UserData actualData)
        {
            actualData.EmailID.ShouldBe(EmailID);
            actualData.Password.ShouldBe(Password);
           

            return true;
        }

    }
}
