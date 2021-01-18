using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Outside.OrderStreamSync
{
  public  interface IDepartmentIdQuery
    {
        Task<int> GetIdBy(string DepartmentDescription);

        Task<string> GetDepartmentBy(int EmployeeID);

        Task<int> RemoveEmpByID(int EmployeeID);


    }
}
