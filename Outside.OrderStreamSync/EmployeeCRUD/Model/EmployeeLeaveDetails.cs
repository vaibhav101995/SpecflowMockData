using System;
using System.Collections.Generic;
using System.Text;

namespace Outside.OrderStreamSync.EmployeeCRUD.Model
{
    public class EmployeeLeaveDetails
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string LeaveType { get; set; }
        public string LStartDate { get; set; }
        public string LEndDate { get; set; }
        public int LeaveDays { get; set; }
        public string LeaveStatus { get; set; }

        public EmployeeLeaveDetails()
        {
        }

        public EmployeeLeaveDetails(int EID, string EmpName, string LType, string StartDate, string EndDATE, int LDays, string LStatus)
        {
            EmployeeID = EID;
            EmployeeName = EmpName;
            LeaveType = LType;
            LStartDate = StartDate;
            LEndDate = EndDATE;
            LeaveDays = LDays;
            LeaveStatus = LStatus;
        }

    }
}
