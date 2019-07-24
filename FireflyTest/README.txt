Automation Practical Test
Prerequisites:

1.	Visual studio solution named “Firefly Test” is provided
2.	This solution contains following NuGet packages pre configured
	•	Selenium.WebDriver
	•	Selenium.WebDriver. ChromeDriver
	•	Specflow
	•	NUnit
	•	NUnit3TestAdapter
	•	DotNetSeleniumExtras.WaitHelpers
	•	FluentAssertions
3.	You can use any Assertions Framework you like to complete the test.
4.	This Test needs to be written in C#.
5.	Take approximately an hour to complete it.
6.  Use git to show your working...


Test case[s] to automate

Successful teacher Login and Edit task scenario in chrome browser
Credentials:
	  User Name   : tteacher
	  Password    : spitfire

Edit Task - Test Case
1.	Open Login Page from https://fireflyautotest.staging.fireflysolutions.co.uk
2.	Enter valid credential for teacher on login page
3.	Click on “Log in” on login page
4.	Verify that teacher is logged in and ‘Set a new task’ button is visible on the dashboard. 
5.	Click on “Tasks” on Dashboard Page
6.	Click on “All” filter option 
7.	Verify the task “Automation Test Task” is present on the task list
8.	Click Task Title
9.	Click on “Task Overview” button
10.	Edit the “Automation Test Task” to “Automation Test Task-Edited”
11.	Verify the task has been edited
 

Before scenario:
Navigate to test site  https://fireflyautotest.staging.fireflysolutions.co.uk 
(this will open Firefly login screen)
After scenario:
Perform explicit user logout by navigating to https://fireflyautotest.staging.fireflysolutions.co.uk/logout