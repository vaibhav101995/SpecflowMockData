using System;
using System.Collections.Generic;
using System.Text;
using Outside.OrderStreamSync.EmployeeCRUD.Model;
using Shouldly;

namespace Outside.OrderStreamSync.Specs.Empoyee_Spec
{
    class LeaveRequestVerify
    {
        public string LeaveType { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int LeaveDays { get; set; }

        public LeaveRequestVerify(string leavetype, string startdt, string enddt, int leavedays)
        {
            LeaveType = leavetype;
            StartDate = startdt;
            EndDate = enddt;
            LeaveDays = leavedays;
        }

        public bool Matches(LeaveData actualData)
        {
            actualData.LeaveType.ShouldBe(LeaveType);
            actualData.StartDate.ShouldBe(StartDate);
            actualData.EndDate.ShouldBe(EndDate);
            actualData.LeaveDays.ShouldBe(LeaveDays);

            return true;
        }
    }
}
