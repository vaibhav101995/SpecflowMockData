using Gherkin.Ast;
using Moq;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Outside.OrderStreamSync.Specs.Department_Spec
{
    [Binding,Scope(Feature = "Departments")]
    public class DepartmentsSteps
    {
        private readonly DepartmentSync _DepartmentSyncer;
        private readonly Mock<IDepartment> _departmentPersisterMock;

        public DepartmentsSteps()
        {
            _departmentPersisterMock = new Mock<IDepartment>();
            _DepartmentSyncer = new DepartmentSync(new DepartmentFactory(), _departmentPersisterMock.Object);
        }

        [Given(@"I click the ""(.*)"" MenuBar to show all deparments data")]
        public async Task GivenIClickTheMenuBarToShowAllDeparmentsData(string p0)
        {
            Department department = new Department(1, "IT", 5, "Pune");
            await _DepartmentSyncer.Add(department);
        }
        
        [Given(@"I click the ""(.*)"" Button to add new department details from department dasboard")]
        public void GivenIClickTheButtonToAddNewDepartmentDetailsFromDepartmentDasboard(string p0)
        {
        }
        
        [Given(@"New page will open to fill new department data")]
        public void GivenNewPageWillOpenToFillNewDepartmentData()
        {
        }
        
        [Given(@"I fill ""(.*)"" into the ""(.*)"" textbox && ""(.*)"" into the ""(.*)""")]
        public async Task GivenIFillIntoTheTextboxIntoThe(string p0, string p1, string p2, string p3)
        {
            Department emps = new Department(1, p0, 5, p2);
            await _DepartmentSyncer.Add(emps);
        }

        [Given(@"I click the ""(.*)"" Button to update existing department details")]
        public void GivenIClickTheButtonToUpdateExistingDepartmentDetails(string p0)
        {
        }
        
        [Given(@"New page will open with existing department data")]
        public void GivenNewPageWillOpenWithExistingDepartmentData()
        {
        }
        
        [Given(@"I fill ""(.*)"" into the ""(.*)"" to update departmentName")]
        public async Task GivenIFillIntoTheToUpdateDepartmentName(string p0, string p1)
        {
            Department department = new Department(1, "ITDesk", 5, "Pune");
            await _DepartmentSyncer.Update(department);
        }
        
        [Given(@"I click the ""(.*)"" Button to delete existing department details")]
        public async Task GivenIClickTheButtonToDeleteExistingDepartmentDetails(string p0)
        {
            Department department = new Department(1, "IT", 5, "Pune");
            await _DepartmentSyncer.Remove(department);
        }
        
        [Then(@"validate following Department Details  should be shown on the screen")]
        public void ThenValidateFollowingDepartmentDetailsShouldBeShownOnTheScreen(Table table)
        {
            DepartmentExample department = new DepartmentExample(1, "IT", 5, "Pune");
            _departmentPersisterMock.Verify(p => p.Persist(It.Is<Department>(actualData => 
            department.Matches(actualData))));
        }

        [Then(@"validate following department details should be added into department data")]
        public void ThenValidateFollowingDepartmentDetailsShouldBeAddedIntoDepartmentData(Table table)
        {
            DepartmentExample department = new DepartmentExample(1, "IT", 5, "Pune");
            _departmentPersisterMock.Verify(p => p.Persist(It.Is<Department>(actualData =>
            department.Matches(actualData))));
        }

        [Then(@"validate following department details should be updated into department data")]
        public void ThenValidateFollowingDepartmentDetailsShouldBeUpdatedIntoDepartmentData(Table table)
        {
            DepartmentExample department = new DepartmentExample(1, "ITDesk", 5, "Pune");
            _departmentPersisterMock.Verify(p => p.Update(It.Is<Department>(actualData => department.Matches(actualData))));
        }

        [Then(@"validate following department details has been deleted from department data")]
        public void ThenValidateFollowingDepartmentDetailsHasBeenDeletedFromDepartmentData(Table table)
        {
            DepartmentExample department = new DepartmentExample();
            _departmentPersisterMock.Verify(p => p.Remove(It.Is<Department>(actualData => department.Matches(actualData))));
        }
    }
}
