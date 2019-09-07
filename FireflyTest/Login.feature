Feature: Login
	In order to use ths system
	As a user
	I want to be be able to login

@loginTests
Scenario: Successfully Login
	Given I have entered a valid UserName and Password
	And I click Login
	Then the Dashboards page will be displayed
