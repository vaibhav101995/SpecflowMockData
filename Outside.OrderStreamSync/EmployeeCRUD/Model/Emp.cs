using System;
using System.Collections.Generic;
using System.Text;

namespace Outside.OrderStreamSync
{
  public  class Emp
    {
        public int id { get; set; }
        public string employeeName { get; set; }
        public string department { get; set; }
        public string mailID { get; set; }
        public Emp()
        {
        }
            public Emp(int ID, string empName, string dept, string MailID)
        {
            id = ID;
            employeeName = empName;
            department = dept;
            mailID = MailID;
        }
       
    }
}
