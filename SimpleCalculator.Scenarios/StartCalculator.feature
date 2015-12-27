Feature: StartCalculator
	In order to start using the SimpleCalculator application
	As a normal user
	I want to see all the components of the SimpleCalculator application displayed

Scenario: Start SimpleCalculator App
	Given I have started the browser
	When I have gone to the proper url address of the SimpleCalculator application
	Then the panels of the SimpleCalculator should be displayed
	And the display panel should contain the number zero
	And the buttons of the SimpleCalculator should be displayed