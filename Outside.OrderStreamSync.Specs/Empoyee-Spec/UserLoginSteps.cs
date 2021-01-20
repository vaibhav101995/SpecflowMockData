using Moq;
using Outside.OrderStreamSync.EmployeeCRUD.Model;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Outside.OrderStreamSync.Specs.Empoyee_Spec
{
    [Binding]
    public class UserLoginSteps
    {
        private readonly Mock<IDepartmentIdQuery> _departmentQueryMock;
        private readonly EmployeeSync _EmpSyncer;
        private readonly Mock<IEmployee> _empPersisterMock;


        public UserLoginSteps()
        {
            _departmentQueryMock = new Mock<IDepartmentIdQuery>();
            _empPersisterMock = new Mock<IEmployee>();
            _EmpSyncer = new EmployeeSync(_departmentQueryMock.Object, new EmployeeDetailFactory(), _empPersisterMock.Object);
        }

        [Given(@"I open the Employee Dashboard & able to see User login page")]
        public void GivenIOpenTheEmployeeDashboardAbleToSeeUserLoginPage()
        {
        }
        
        [Given(@"I fill ""(.*)"" into the emailID textbox && ""(.*)"" into the Password textbox")]
        public async Task GivenIFillIntoTheEmailIDTextboxIntoThePasswordTextbox(string emailID, string Password)
        {
            UserLogin emps = new UserLogin(emailID, Password);
            await _EmpSyncer.AddUser(emps);
        }
        
        [When(@"I click the ""(.*)"" button")]
        public void WhenIClickTheButton(string p0)
        {
        }
        
        [Then(@"validate '(.*)' on the screen && user can able to see Employee Dashboard")]
        public void ThenValidateOnTheScreenUserCanAbleToSeeEmployeeDashboard(string p0)
        {
            UserVerify useExample = new UserVerify("a@gmail.com", "NewUser123");
            _empPersisterMock.Verify(p => p.UserStore(It.Is<UserData>(actualData => useExample.Matches(actualData))));

        }
    }
}
