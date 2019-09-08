Feature: Edit Task
	In order to update Tasks
	As a user
	I want to navigate to Edit Tasks and make Changes


@editTaskTests
Scenario: Edit Task
	Given I click on Tasks on the Dashboard
		And I filter the list by "All"
		And I click on "Automation Test Task"
		And I click on Task Overview
	When I Edit the task name to "Automation Test Task-Edited"
	Then the task name is successfully updated
