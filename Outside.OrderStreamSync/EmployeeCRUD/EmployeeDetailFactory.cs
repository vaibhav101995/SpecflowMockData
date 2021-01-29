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

        LeaveData AddLeave(LeaveRequest leavedata);

        LeaveData AddLeave1(LeaveRequest leavedata);

        EmployeeLeaveDetails Approved(EmployeeLeaveDetails approve, string EmpName);
        EmployeeLeaveDetails LeaveApproval(EmployeeLeaveDetails approve);

        EmployeeLeaveDetails ApproveEmpLeave(EmployeeLeaveDetails approveleave, string empName);
        EmployeeLeaveDetails RejectEmpLeave(EmployeeLeaveDetails rejectleave, string empName);
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
        public LeaveData AddLeave(LeaveRequest leavedata)
        {
            return new LeaveData
            {
                LeaveType = leavedata.LeaveType,
                StartDate = leavedata.StartDate,
                EndDate = leavedata.EndDate,
                LeaveDays = leavedata.LeaveDays,
            };
        }

        public LeaveData AddLeave1(LeaveRequest leavedata)
        {
            return new LeaveData
            {
                LeaveType = leavedata.LeaveType,
                StartDate = leavedata.StartDate,
                EndDate = leavedata.EndDate,
                LeaveDays = leavedata.LeaveDays,
            };
        }

        public EmployeeLeaveDetails Approved(EmployeeLeaveDetails approve, string EmpName)
        {
            return new EmployeeLeaveDetails
            {
                EmployeeID = approve.EmployeeID,
                EmployeeName = approve.EmployeeName,
                LeaveType = approve.LeaveType,
                LStartDate = approve.LStartDate,
                LEndDate = approve.LEndDate,
                LeaveDays = approve.LeaveDays,
                LeaveStatus = approve.LeaveStatus
            };
        }

        //public EmployeeLeaveDetails LeaveApproval(EmployeeLeaveDetails approve, string EmpName)
        //{
        //    throw new NotImplementedException();
        //}

        public EmployeeLeaveDetails LeaveApproval(EmployeeLeaveDetails approve)
        {
            return new EmployeeLeaveDetails
            {
                EmployeeID = approve.EmployeeID,
                EmployeeName = approve.EmployeeName,
                LeaveType = approve.LeaveType,
                LStartDate = approve.LStartDate,
                LEndDate = approve.LEndDate,
                LeaveDays = approve.LeaveDays,
                LeaveStatus = approve.LeaveStatus
            };
        }

        public EmployeeLeaveDetails ApproveEmpLeave(EmployeeLeaveDetails approveleave, string empName)
        {
            return new EmployeeLeaveDetails
            {
                EmployeeID = approveleave.EmployeeID,
                EmployeeName = approveleave.EmployeeName,
                LeaveType = approveleave.LeaveType,
                LStartDate = approveleave.LStartDate,
                LEndDate = approveleave.LEndDate,
                LeaveDays = approveleave.LeaveDays,
                LeaveStatus = approveleave.LeaveStatus
            };
        }

        public EmployeeLeaveDetails RejectEmpLeave(EmployeeLeaveDetails rejectleave, string empName)
        {
            return new EmployeeLeaveDetails
            {
                EmployeeID = rejectleave.EmployeeID,
                EmployeeName = rejectleave.EmployeeName,
                LeaveType = rejectleave.LeaveType,
                LStartDate = rejectleave.LStartDate,
                LEndDate = rejectleave.LEndDate,
                LeaveDays = rejectleave.LeaveDays,
                LeaveStatus = rejectleave.LeaveStatus
            };
        }

    }
}
