using System;
using System.Collections.Generic;
using System.Text;

namespace Outside.OrderStreamSync
{
    public class Department
    {
        public int id { get; set; }
        public string departmentName { get; set; }
        public int noOfEmployees { get; set; }
        public string departmentLocation { get; set; }

        public Department()
        {

        }
        public Department(int _id, string _departmentName, int _noOfEmployees, string _departmentLocation)
        {
            id = _id;
            departmentName = _departmentName;
            noOfEmployees = _noOfEmployees;
            departmentLocation = _departmentLocation;
        }
    }
}
