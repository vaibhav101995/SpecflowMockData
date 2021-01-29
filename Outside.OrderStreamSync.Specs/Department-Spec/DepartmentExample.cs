using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;

namespace Outside.OrderStreamSync.Specs.Department_Spec
{
    public class DepartmentExample
    {
        public int id { get; set; }
        public string departmentName { get; set; }
        public int noOfEmployees { get; set; }
        public string departmentLocation { get; set; }

        public DepartmentExample()
        {
        }
        public DepartmentExample(int _id, string _departmentName, int _noOfEmployees, string _departmentLocation)
        {
            id = _id;
            departmentName = _departmentName;
            noOfEmployees = _noOfEmployees;
            departmentLocation = _departmentLocation;
        }

        public bool Matches(Department actualData)
        {
            actualData.id.ShouldBe(id);
            actualData.departmentName.ShouldBe(departmentName);
            actualData.noOfEmployees.ShouldBe(noOfEmployees);
            actualData.departmentLocation.ShouldBe(departmentLocation);
            return true;
        }
    }
}
