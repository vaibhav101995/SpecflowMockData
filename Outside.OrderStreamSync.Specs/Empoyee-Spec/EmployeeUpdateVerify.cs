using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;

namespace Outside.OrderStreamSync.Specs
{
  public  class EmployeeUpdateVerify
    {
        public int id { get; set; }
        public string employeeName { get; set; }
        public string department { get; set; }
        public string mailID { get; set; }

        public EmployeeUpdateVerify()
        {
        }
        public EmployeeUpdateVerify(int ID, string empName, string dept, string MailID)
        {
            id = ID;
            employeeName = empName;
            department = dept;
            mailID = MailID;
        }
            public bool Matches(Emp actualData)
        {
            actualData.id.ShouldBe(id);
            actualData.employeeName.ShouldBe(employeeName);
           actualData.department.ShouldBe(department);
           actualData.mailID.ShouldBe(mailID);

            return true;
        }
    }
}
