@Leesa_LoginPage
Feature: Leesa-LoginPage
	As a User 
	I would like to be able to use the Login feature

Scenario Outline: Verify New Registration is working correctly
	Given User lands on Leesa Website
	Then User is on Login Page
	Then User click on register new account
	And Verify Create an account is displayed
	Then User enters registration details '<FirstName>', '<LastName>', '<EmailAddress>', '<Password>'
	And click on create button
	Then verify account login is displayed

	Examples:
		| FirstName | LastName | EmailAddress              | Password |
		| Chetan    | Bhutra   | Chetanbhutra921@gmail.com | Chetan   |

Scenario Outline: Verify Login is working correctly
	Given User lands on Leesa Website
	Then User is on Login Page
	Then User enters login details '<EmailAddress>', '<Password>'
	And click on create button
	Then verify user dashboard is displayed

	Examples:
		| EmailAddress       | Password         |
		| bilton00@gmail.com | orangeWings@!123 |