using Moq;
using Outside.OrderStreamSync.EmployeeCRUD.Model;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Outside.OrderStreamSync.Specs.Empoyee_Spec
{
    [Binding]
    public class EmployeeLeaveDetailsSteps
    {
        private readonly Mock<IDepartmentIdQuery> _departmentQueryMock;
        private readonly EmployeeSync _EmpSyncer;
        private readonly Mock<IEmployee> _empPersisterMock;
        public EmployeeLeaveDetailsSteps()
        {
            _departmentQueryMock = new Mock<IDepartmentIdQuery>();
            _empPersisterMock = new Mock<IEmployee>();
            _EmpSyncer = new EmployeeSync(_departmentQueryMock.Object, new EmployeeDetailFactory(), _empPersisterMock.Object);
        }

        [Given(@"I  open the Sample Portal")]
        public void GivenIOpenTheSamplePortal()
        {
        }
        
        [Given(@"I click the ""(.*)"" MenuBar to open submenu bar")]
        public void GivenIClickTheMenuBarToOpenSubmenuBar(string p0)
        {
        }
        
        [Given(@"I click the ""(.*)""  to show Employee Leave Details")]
        public void GivenIClickTheToShowEmployeeLeaveDetails(string p0)
        {
        }
        
        [Given(@"a new page will open  with existing employee Leave data")]
        public void GivenANewPageWillOpenWithExistingEmployeeLeaveData()
        {
        }
        
        [Given(@"the  existing data is ""(.*)"" && ""(.*)"" && ""(.*)"" && ""(.*)"" && ""(.*)"" && ""(.*)"" && ""(.*)""")]
        public async Task  GivenTheExistingDataIs(int p0, string p1, string p2, string p3, string p4, int p5, string p6)
        {
            EmployeeLeaveDetails emp = new EmployeeLeaveDetails(1, "Amit", "Earned", "01-01-2020", "01-02-2020", 1, "Submitted");
            await _EmpSyncer.Sync(emp);
        }

        [Given(@"I open Sample Portal")]
        public void GivenIOpenSamplePortal()
        {
        }
        
        [Given(@"I click the ""(.*)"" MenuBar to open the submenu bar")]
        public void GivenIClickTheMenuBarToOpenTheSubmenuBar(string p0)
        {
        }
        
        [Given(@"I click the ""(.*)""  to show the Employee Leave Details")]
        public void GivenIClickTheToShowTheEmployeeLeaveDetails(string p0)
        {
        }
        
        [Given(@"New  page will open with existing employee Leave data")]
        public void GivenNewPageWillOpenWithExistingEmployeeLeaveData()
        {
        }
        
        [Given(@"Existing  data is ""(.*)"" && ""(.*)"" && ""(.*)"" && ""(.*)"" && ""(.*)"" && ""(.*)"" && ""(.*)""")]
        public void GivenExistingDataIs(int p0, string p1, string p2, string p3, string p4, int p5, string p6)
        {
        }
        
        [When(@"I click the ""(.*)"" Button to  approve employee leaves")]
        public void WhenIClickTheButtonToApproveEmployeeLeaves(string p0)
        {
        }
        
        [When(@"I click the ""(.*)"" Button to reject the employee leaves")]
        public void WhenIClickTheButtonToRejectTheEmployeeLeaves(string p0)
        {
        }
        
        [Then(@"validate following employee details are added  into employee data")]
        public async Task  ThenValidateFollowingEmployeeDetailsAreAddedIntoEmployeeData(Table table)
        {
            EmployeeLeaveDetails emp = new EmployeeLeaveDetails(1, "Amit", "Earned", "01-01-2020", "01-02-2020", 1, "Approved");
            await _EmpSyncer.ApproveEmpLeave(emp);
        }
        
        [Then(@"validate following employee  details are added  into the employee data")]
        public async Task ThenValidateFollowingEmployeeDetailsAreAddedIntoTheEmployeeData(Table table)
        {
            EmployeeLeaveDetails emp = new EmployeeLeaveDetails(1, "Amit", "Earned", "01-01-2020", "01-02-2020", 1, "Rejected");
            await _EmpSyncer.RejectEmpLeave(emp);

        }
    }
}
