using System;
using System.Collections.Generic;
using System.Text;

namespace Outside.OrderStreamSync
{
  public  class EmployeeData
    {
        public int id { get; set; }
        public string employeeName { get; set; }
        public int departmentID { get; set; }
        public string mailID { get; set; }

        public EmployeeData()
        {
        }
            public EmployeeData(int ID, string empName, int deptID, string MailID)
        {
            id = ID;
            employeeName = empName;
            departmentID = deptID;
            mailID = MailID;
        }

        //List<EmployeeData> emps = new List<EmployeeData>
        //    {
        //                  new EmployeeData  {id= 1,employeeName="Amit",departmentID=0, mailID= "a@gmail.com" }

        //    };
    }
}
