using Moq;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Outside.OrderStreamSync.Specs.Empoyee_Spec
{
    [Binding]
    public class EmpSteps
    {
        private readonly Mock<IDepartmentIdQuery> _departmentQueryMock;
        private readonly EmployeeSync _EmpSyncer;
        private readonly Mock<IEmployee> _empPersisterMock;


        public EmpSteps()
        {
            _departmentQueryMock = new Mock<IDepartmentIdQuery>();
            _empPersisterMock = new Mock<IEmployee>();
            _EmpSyncer = new EmployeeSync(_departmentQueryMock.Object, new EmployeeDetailFactory(), _empPersisterMock.Object);
        }

        [Given(@"I open the Sample Portal")]
        public void GivenIOpenTheSamplePortal()
        {
        }
        
        [Given(@"I click the ""(.*)""  MenuBar  to show all employee details")]
        public async Task GivenIClickTheMenuBarToShowAllEmployeeDetails(string p0)
        {
            Emp emps = new Emp( 1, "Amit", "IT", "a@gmail.com" );
            await _EmpSyncer.Sync(emps);
        }
        
        [Given(@"I click the ""(.*)"" MenuBar to show all employee data")]
        public void GivenIClickTheMenuBarToShowAllEmployeeData(string p0)
        {
        }
        
        [Given(@"I click the ""(.*)"" Button to add employee details from employee dasboard")]
        public void GivenIClickTheButtonToAddEmployeeDetailsFromEmployeeDasboard(string p0)
        {
        }
        
        [Given(@"New page will open to fill new employee data")]
        public void GivenNewPageWillOpenToFillNewEmployeeData()
        {
        }
        
        [Given(@"I fill ""(.*)"" into the ""(.*)"" textbox && ""(.*)"" into the ""(.*)"" && ""(.*)"" into the ""(.*)"" && ""(.*)"" into the ""(.*)""")]
        public async Task GivenIFillIntoTheTextboxIntoTheIntoTheIntoThe(int p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7)
        {
            Emp emps = new Emp(p0, p2, p4, p6);
            await _EmpSyncer.Sync(emps);

        }

        [Given(@"I click the ""(.*)"" MenuBar  to show all employees data")]
        public void GivenIClickTheMenuBarToShowAllEmployeesData(string p0)
        {
        }
        
        [Given(@"I click the ""(.*)"" Button to update existing employee details")]
        public void GivenIClickTheButtonToUpdateExistingEmployeeDetails(string p0)
        {
        }
        
        [Given(@"New page will open with existing employee data")]
        public void GivenNewPageWillOpenWithExistingEmployeeData()
        {
        }
        
        [Given(@"I fill ""(.*)"" into the ""(.*)"" to update employeeName")]
        public async Task GivenIFillIntoTheToUpdateEmployeeName(string p0, string p1)
        {
            Employee emps = new Employee(1, p0, "IT", "a@gmail.com");
             await _EmpSyncer.UpdateEmpName(emps);

        }

        [Given(@"I click the ""(.*)"" MenuBar to  show all emp data")]
        public void GivenIClickTheMenuBarToShowAllEmpData(string p0)
        {
        }
        
        [Given(@"I click the ""(.*)"" Button to delete existing employee details")]
        public async Task GivenIClickTheButtonToDeleteExistingEmployeeDetails(string p0)
        {
            Employee emps = new Employee(1, "Amit", "IT", "a@gmail.com");
            await _EmpSyncer.RemoveEmp(emps);
        }

        [Given(@"New page will open with Confirmation of deletion")]
        public void GivenNewPageWillOpenWithConfirmationOfDeletion()
        {
        }
        
        [Then(@"validate following Employee Details  is displayed on the screen")]
        public async Task ThenValidateFollowingEmployeeDetailsIsDisplayedOnTheScreen(Table table)
        {
            EmployeeExample empExample = new EmployeeExample(1, "Amit", 0, "a@gmail.com");
            _empPersisterMock.Verify(p => p.Persist(It.Is<EmployeeData>(actualData => empExample.Matches(actualData))));
        }

        [Then(@"I click the ""(.*)"" button")]
        public void ThenIClickTheButton(string p0)
        {
           
        }
        
        [Then(@"validate following employee  details are added  into employee data")]
        public void ThenValidateFollowingEmployeeDetailsAreAddedIntoEmployeeData(Table table)
        {
             EmployeeExample empExample = new EmployeeExample(1, "AMIT", 0, "t@test.com");
            _empPersisterMock.Verify(p => p.Persist(It.Is<EmployeeData>(actualData => empExample.Matches(actualData))));

        }

        [Then(@"validate following employee details are updated into employee data")]
        public void ThenValidateFollowingEmployeeDetailsAreUpdatedIntoEmployeeData(Table table)
        {
            EmployeeUpdateVerify empExample = new EmployeeUpdateVerify(1, "Rohit", "IT", "a@gmail.com");
             _empPersisterMock.Verify(p => p.UpdateDepartment(It.Is<Emp>(actualData => empExample.Matches(actualData))));

        }

        [Then(@"validate following  employee details  are deleted into employee data")]
        public void ThenValidateFollowingEmployeeDetailsAreDeletedIntoEmployeeData(Table table)
        {
            EmployeeUpdateVerify empExample = new EmployeeUpdateVerify();
            _empPersisterMock.Verify(p => p.RemoveEmp(It.Is<Emp>(actualData => empExample.Matches(actualData))));
        }
    }
}
