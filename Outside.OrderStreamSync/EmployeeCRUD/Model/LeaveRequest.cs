using System;
using System.Collections.Generic;
using System.Text;

namespace Outside.OrderStreamSync.EmployeeCRUD.Model
{
    public class LeaveRequest
    {
        public string LeaveType { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int LeaveDays { get; set; }

        public LeaveRequest()
        {
        }
        public LeaveRequest(string leavetype, string startdt, string enddt, int leavedays)
        {
            LeaveType = leavetype;
            StartDate = startdt;
            EndDate = enddt;
            LeaveDays = leavedays;
        }
    }
}
