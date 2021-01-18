using Outside.OrderStreamSync.EmployeeCRUD.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Outside.OrderStreamSync
{
  public  class EmployeeSync
    {
        private readonly IDepartmentIdQuery _departmentIdQuery;
        private readonly IEmployeeDetailFactory _employeeFactory;
        private readonly IEmployee _emplPersister;
        
        public EmployeeSync(
           IDepartmentIdQuery departmentIdQuery,
            IEmployeeDetailFactory employee,
            IEmployee empDetail)
        {
            _emplPersister = empDetail;
            _employeeFactory = employee;
            _departmentIdQuery = departmentIdQuery;
            
        }

        public async Task Sync(Emp empl)
        {
            var departmentId = 0;
            var employee = _employeeFactory.InstantiateFrom(empl, departmentId);
            await _emplPersister.Persist(employee);
        }
        public async Task UpdateEmpName(Employee empl)
        {
            var empName = empl.employeeName;
            var employee = _employeeFactory.UpdateEmpName(empl, empName);
            await _emplPersister.UpdateDepartment(employee);
        }
        public async Task RemoveEmp(Employee empl)
        {
           var EmpId = await _departmentIdQuery.RemoveEmpByID(empl.id);
            var employee = _employeeFactory.RemoveEmp(empl, EmpId);
            await _emplPersister.RemoveEmp(employee);
        }
        public async Task AddUser(UserLogin user)
        {
           // var departmentId = 0;
            var userData = _employeeFactory.AddUser(user);
            await _emplPersister.UserStore(userData);
        }

    }
}
