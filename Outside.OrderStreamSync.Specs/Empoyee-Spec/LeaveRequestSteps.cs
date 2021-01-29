using Moq;
using Outside.OrderStreamSync.EmployeeCRUD.Model;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Outside.OrderStreamSync.Specs.Empoyee_Spec
{
    [Binding]
    public class LeaveRequestSteps
    {
        private readonly Mock<IDepartmentIdQuery> _departmentQueryMock;
        private readonly EmployeeSync _EmpSyncer;
        private readonly Mock<IEmployee> _empPersisterMock;


        public LeaveRequestSteps()
        {
            _departmentQueryMock = new Mock<IDepartmentIdQuery>();
            _empPersisterMock = new Mock<IEmployee>();
            _EmpSyncer = new EmployeeSync(_departmentQueryMock.Object, new EmployeeDetailFactory(), _empPersisterMock.Object);
        }

        [Given(@"I    open  the Sample Portal")]
        public void GivenIOpenTheSamplePortal()
        {
        
        }
        
        [Given(@"I  click  the  ""(.*)""  MenuBar  to show all leavedetails details")]
        public void GivenIClickTheMenuBarToShowAllLeavedetailsDetails(string p0)
        {
        
        }
        
        [Given(@"I  click the  ""(.*)""  SubMenuBar  to show all leavedetails details")]
        public void GivenIClickTheSubMenuBarToShowAllLeavedetailsDetails(string p0)
        {
        
        }
        
        [Given(@"New page    will  open to fill new leavedetails data")]
        public void GivenNewPageWillOpenToFillNewLeavedetailsData()
        {
        
        }
        
        [Given(@"I  fill  ""(.*)"" into  the Leavetype textbox && ""(.*)"" into the Startdate textbox && ""(.*)"" into the Enddate textbox && ""(.*)"" into the Leavedays textbox")]
        public async Task GivenIFillIntoTheLeavetypeTextboxIntoTheStartdateTextboxIntoTheEnddateTextboxIntoTheLeavedaysTextbox(string p0, string p1, string p2, int p3)
        {
            LeaveRequest lrs = new LeaveRequest(p0, p1, p2, p3);
            await _EmpSyncer.AddLeave(lrs);
        }
        
        [Given(@"I open  Sample Portal")]
        public void GivenIOpenSamplePortal()
        {
            
        }
        
        [Given(@"I click ""(.*)""   MenuBar  to show all details")]
        public void GivenIClickMenuBarToShowAllDetails(string p0)
        {
            
        }
        
        [Given(@"I click ""(.*)""   SubMenuBar  to show all leavedetails details")]
        public void GivenIClickSubMenuBarToShowAllLeavedetailsDetails(string p0)
        {
            
        }
        
        [Then(@"I   click  the ""(.*)""  button")]
        public void ThenIClickTheButton(string p0)
        {
            
        }
        
        [Then(@"validate   following  leavedetails   details are added  into leavedetails data")]
        public async Task ThenValidateFollowingLeavedetailsDetailsAreAddedIntoLeavedetailsData(Table table)
        {
            LeaveRequestVerify leaveExample = new LeaveRequestVerify("Planned Leave", "02-11-2010", "04-11-2021", 4);
            _empPersisterMock.Verify(p => p.UserLeave(It.Is<LeaveData>(actualData => leaveExample.Matches(actualData))));
        }
        
        [Then(@"I  click ""(.*)"" button")]
        public void ThenIClickButton(string p0)
        {
            
        }
        
        [Then(@"validate   following   leavedetails Details  is displayed on the screen")]
        public async Task ThenValidateFollowingLeavedetailsDetailsIsDisplayedOnTheScreen(Table table)
        {
            LeaveRequest lrs = new LeaveRequest("Planned Leave", "06-10-2020", "04-11-2021", 5);
            await _EmpSyncer.AddLeave1(lrs);
            LeaveRequestVerify leaveEg = new LeaveRequestVerify("Planned Leave", "06-10-2020", "04-11-2021", 5);
            _empPersisterMock.Verify(p => p.UserLeave1(It.Is<LeaveData>(actualData => leaveEg.Matches(actualData))));
            //await _EmpSyncer.Sync1(lr);

        }
    }
}
