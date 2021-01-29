Feature: Departments
	
	Scenario: Verify user can open department Dashboard for showing department details   
	Given I open the Sample Portal 
	And I click the "Department" MenuBar to show all deparments data
	Then validate following Department Details  should be shown on the screen
	|departmentName | noOfEmployees | departmentLocation |

	Scenario: Verify user can open department dashboard for adding new department data
	Given I open the Sample Portal 
	And I click the "Department" MenuBar to show all deparments data
	And I click the "Add Department" Button to add new department details from department dasboard
	And New page will open to fill new department data 
    And I fill "IT" into the "departmentName" textbox && "Pune" into the "departmentLocation"
    Then I click the "Add Department" button
    Then validate following department details should be added into department data
    |departmentName | departmentLocation|
	
	Scenario: Verify user can open department dashboard for editing department data 
	Given I open the Sample Portal 
	And I click the "Department" MenuBar to show all deparments data
	And I click the "Edit" Button to update existing department details
	And New page will open with existing department data 
    And I fill "ITDesk" into the "departmentName" to update departmentName
	Then I click the "Update Department" button
    Then validate following department details should be updated into department data 
	|departmentName | departmentLocation|
	
	Scenario:  Verify user can open department dashboard for deleting department  
	Given I open the Sample Portal 
	And I click the "Department" MenuBar to show all deparments data
	And I click the "Delete" Button to delete existing department details
	And New page will open with Confirmation of deletion 
	Then I click the "Confirm" button
    Then validate following department details has been deleted from department data 
	|departmentName | departmentLocation|
	
