using Outside.OrderStreamSync.EmployeeCRUD.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Outside.OrderStreamSync
{
    public interface IEmployeeDetailFactory
    {
        EmployeeData InstantiateFrom(Emp empdetail, int departmentId);

        Emp UpdateEmpName(Employee empdetail, string EmpName);

        Emp RemoveEmp(Employee empdetail, int id);

        UserData AddUser(UserLogin userdata);

    }

    public class EmployeeDetailFactory : IEmployeeDetailFactory
    {
        public EmployeeData InstantiateFrom(Emp empdetail, int departmentId)
        {
            return new EmployeeData
            {
                id = empdetail.id,
                employeeName = empdetail.employeeName,
                departmentID = departmentId,
                mailID = empdetail.mailID
            };
        }

      public  Emp UpdateEmpName(Employee empdetail, string EmpName)
        {
            
                return new Emp 
                {
                    id = empdetail.id,
                    employeeName = EmpName,
                    department = empdetail.department,
                    mailID = empdetail.mailID
                };
            
        }

        public Emp RemoveEmp(Employee empdetail, int id)
        {
            Emp e = new Emp();
            return e;
            //return new Emp
            //{
            //    id = empdetail.id,
            //    employeeName = empdetail.employeeName,
            //    department = empdetail.department,
            //    mailID = empdetail.mailID
            //};

        }
        public UserData AddUser(UserLogin userdata)
        {
            return new UserData
            {
              
                EmailID = userdata.EmailID,
                Password = userdata.Password
             
            };
        }

    }
}
