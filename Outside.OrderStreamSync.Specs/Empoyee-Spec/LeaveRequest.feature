Feature: LeaveRequest
	
Scenario: Verify user can open Employee Dashboard for adding new Leave Request details
	Given I    open  the Sample Portal
	And I  click  the  "Transaction"  MenuBar  to show all leavedetails details
	And I  click the  "Leave Request"  SubMenuBar  to show all leavedetails details
	And New page    will  open to fill new leavedetails data 
    And I  fill  "Planned Leave" into  the Leavetype textbox && "02-11-2010" into the Startdate textbox && "04-11-2021" into the Enddate textbox && "4" into the Leavedays textbox
   Then I   click  the "Submit"  button
   Then validate   following  leavedetails   details are added  into leavedetails data 
	| LeaveType | StartDate | EndDate | LeaveDays |

Scenario: Verify user can open Employee Dashboard for viewing Leave Request History details
	Given I open  Sample Portal
	And I click "Transaction"   MenuBar  to show all details
	And I click "Leave Request"   SubMenuBar  to show all leavedetails details 
   Then I  click "View History" button
   Then validate   following   leavedetails Details  is displayed on the screen
	| LeaveType | StartDate | EndDate | LeaveDays | Leave Status 

	