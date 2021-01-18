using Outside.OrderStreamSync.EmployeeCRUD.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Outside.OrderStreamSync
{
   public interface IEmployee
    {
        Task Persist(EmployeeData empdetail);

        Task UpdateDepartment(Emp empdetail);

        Task RemoveEmp(Emp empdetail);

        Task UserStore(UserData Userdetail);
    }
}
