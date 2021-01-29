using System;
using System.Collections.Generic;
using System.Text;

namespace Outside.OrderStreamSync
{
    public interface IDepartmentFactory
    {
        Department Add(Department department);
        Department Update(Department department);
        Department Remove(Department department, int id);
    }

    public class DepartmentFactory : IDepartmentFactory
    {
        public Department Add(Department department)
        {
            return new Department
            {
                id = department.id,
                departmentName = department.departmentName,
                noOfEmployees = department.noOfEmployees,
                departmentLocation = department.departmentLocation
            };
        }

        public Department Update(Department department)
        {
            return new Department
            {
                id = department.id,
                departmentName = department.departmentName,
                noOfEmployees = department.noOfEmployees,
                departmentLocation = department.departmentLocation
            };
        }

        public Department Remove(Department department, int id)
        {
            Department e = new Department();
            return e;
        }
    }
}
