using System;
using System.Collections.Generic;
using System.Text;
using Shouldly;
namespace Outside.OrderStreamSync.Specs
{
 public   class EmployeeExample
    {
        public int id { get; set; }
        public string employeeName { get; set; }
        public int departmentID { get; set; }
        public string mailID { get; set; }

        public EmployeeExample(int ID, string empName, int dept, string MailID)
        {
            id = ID;
            employeeName = empName;
            departmentID = dept;
            mailID = MailID;
        }


        public bool Matches(EmployeeData actualData)
        {
            actualData.id.ShouldBe(id);
            actualData.employeeName.ShouldBe(employeeName);
            actualData.departmentID.ShouldBe(departmentID);
            actualData.mailID.ShouldBe(mailID);

            return true;
        }
    }
}
