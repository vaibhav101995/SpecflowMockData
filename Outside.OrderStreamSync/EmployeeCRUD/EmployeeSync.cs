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

        //AddLeave Function

        public async Task AddLeave(LeaveRequest lruser)
        {

            var userData1 = _employeeFactory.AddLeave(lruser);
            await _emplPersister.UserLeave(userData1);
        }
        //AddLeave1 Function
        public async Task AddLeave1(LeaveRequest lruser)
        {

            var userData1 = _employeeFactory.AddLeave1(lruser);
            await _emplPersister.UserLeave1(userData1);
        }

        public async Task Sync(EmployeeLeaveDetails emp)
        {
            //var departmentId = 0;
            var employee1 = _employeeFactory.LeaveApproval(emp);
            await _emplPersister.Persist(employee1);
        }

        public async Task ApproveEmpLeave(EmployeeLeaveDetails emp)
        {
            var empName = emp.EmployeeName;
            var employee = _employeeFactory.ApproveEmpLeave(emp, empName);
            await _emplPersister.ApproveLeave(employee);

        }

        public async Task RejectEmpLeave(EmployeeLeaveDetails emp)
        {
            var empName = emp.EmployeeName;
            var employee = _employeeFactory.RejectEmpLeave(emp, empName);
            await _emplPersister.RejectLeave(employee);
        }
    }
}
