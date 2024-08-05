@BasicTest
Feature: BasicTest

Scenario: Log in to the application with correct credentials
	Given the user is on the homepage
	When the user is logging in with correct credentials
	Then the user is forwarded to the correct page

Scenario: Log in to the application with invalid credentials
	Given the user is on the homepage
	When the user is logging in with invalid credentials
	Then the user is faced with and error message
	Then the user remains on the login page