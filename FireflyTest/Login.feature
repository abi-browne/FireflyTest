Feature: Login
	In order to use ths sytem
	As a user
	I want to be be able to login

Scenario: Successfully Login
	Given I have entered a valid UserName and Password
	And I click Login
	Then the Dashboards page will be displayed
