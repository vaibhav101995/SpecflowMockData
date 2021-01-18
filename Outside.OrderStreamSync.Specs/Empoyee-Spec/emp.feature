Feature: emp
	
Scenario: Verify user can open Employee Dashboard for showing employee details   
	Given I open the Sample Portal 
	And I click the "Employee"  MenuBar  to show all employee details
	Then validate following Employee Details  is displayed on the screen
	| id | employeeName | departmentID | mailID |

	Scenario: Verify user can open employee dashboard for adding new employee data
	Given I open the Sample Portal 
	And I click the "Employee" MenuBar to show all employee data
	And I click the "Add" Button to add employee details from employee dasboard
	And New page will open to fill new employee data 
    And I fill "1" into the "ID" textbox && "AMIT" into the "employeeName" && "IT" into the "department" && "t@test.com" into the "mailID"
   Then I click the "Add Employee" button
   Then validate following employee  details are added  into employee data 
	| id | employeeName | departmentID | mailID |
	
	Scenario: Verify user can open employee dashboard for editing employee data 
	Given I open the Sample Portal 
	And I click the "Employee" MenuBar  to show all employees data
	And I click the "Edit" Button to update existing employee details
	And New page will open with existing employee data 
    And I fill "Rohit" into the "employeeName" to update employeeName
	Then I click the "Update Employee" button
    Then validate following employee details are updated into employee data 
	| id | employeeName | departmentID | mailID |
	

	Scenario:  Verify user can open employee dashboard for deleting employee  
	Given I open the Sample Portal 
	And I click the "Employee" MenuBar to  show all emp data
	And I click the "Delete" Button to delete existing employee details
	And New page will open with Confirmation of deletion 
	Then I click the "Confirm" button
    Then validate following  employee details  are deleted into employee data 
	| id | employeeName | departmentID | mailID |
	
