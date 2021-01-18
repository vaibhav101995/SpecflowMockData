Feature: UserLogin

Scenario:  Verify User can able to Login using EmailID & Password
	Given I open the Employee Dashboard & able to see User login page 
    And I fill "a@gmail.com" into the emailID textbox && "NewUser123" into the Password textbox  
	When I click the "Submit" button
	Then validate 'User Details' on the screen && user can able to see Employee Dashboard 
	 