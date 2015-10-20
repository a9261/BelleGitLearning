Feature: CalSum
	For User cal sum 
	Belle first test code

@mytag
Scenario: Add two numbers
	Given I have entered First 819 into the calculator
	And I have entered Second 820 into the calculator
	When I press add
	Then the result should be 1639 on the screen
