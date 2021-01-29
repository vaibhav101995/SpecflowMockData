Feature: EmployeeLeaveDetails

Scenario: Verify user can open Employee Dashboard for approving Leaves
	Given I  open the Sample Portal
	And I click the "Transaction" MenuBar to open submenu bar
	And I click the "Employee Leave Details"  to show Employee Leave Details
	And a new page will open  with existing employee Leave data 
	And the  existing data is "1" && "Amit" && "Earned" && "01-01-2020" && "01-01-2020" && "1" && "Submitted"
	When I click the "Approve" Button to  approve employee leaves
	Then validate following employee details are added  into employee data 
	| EmployeeID | EmployeeName  | LeaveType | LStartDate | LEndDate | LeaveDays | LeaveStatus |

Scenario: Verify user can open Employee Dashboard for rejecting Leaves
	Given I open Sample Portal
	And I click the "Transaction" MenuBar to open the submenu bar
	And I click the "Employee Leave Details"  to show the Employee Leave Details
	And New  page will open with existing employee Leave data 
	And Existing  data is "1" && "Amit" && "Earned" && "01-01-2020" && "01-01-2020" && "1" && "Submitted"
	When I click the "Reject" Button to reject the employee leaves
	Then validate following employee  details are added  into the employee data 
	| EmployeeID | EmployeeName | LeaveType | LStartDate | LEndDate | LeaveDays | LeaveStatus | 	