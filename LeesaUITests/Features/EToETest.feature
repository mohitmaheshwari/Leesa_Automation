@Leesa_EndToEndTest
Feature: Leesa-EndToEndTest
	As a User 
	I would like to be able to use the EndToEnd feature

Scenario: Verify User is successfully able to purchase a product
	Given User lands on Leesa Website
	Then User is on Login Page
	Then User enters login details '<EmailAddress>', '<Password>'
	And click on create button
	Then verify user dashboard is displayed

	Examples:
		| EmailAddress       | Password         |
		| bilton00@gmail.com | orangeWings@!123 |


	
