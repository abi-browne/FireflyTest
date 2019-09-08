using FireflyTest.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace FireflyTest.StepDefinitions
{
    [Binding, Scope(Tag = "editTaskTests")]
    public class EditTaskSteps
    {
        private LoginPage loginPage;
        private DashboardPage dashboardPage;
        private SetTaskPage setTaskPage;
        private TaskPage taskPage;
        private EditTaskPage editTaskPage;
        private Driver driver;
        private string newTaskName = "";

        [BeforeScenario("editTaskTests")]
        public void Before()
        {
            driver = new Driver();
            loginPage = new LoginPage(driver);
            dashboardPage = new DashboardPage(driver);
            setTaskPage = new SetTaskPage(driver);
            taskPage = new TaskPage(driver);
            editTaskPage = new EditTaskPage(driver);
            loginPage.PopulateLogin("tteacher", "spitfire");
            loginPage.ClickLogin();
        }

        [AfterScenario("editTaskTests")]
        public void After()
        {
            //driver.logout();

            //if (driver != null)
            //{
            //    driver.Quit();
            //}
        }

        [Given(@"I click on Tasks on the Dashboard")]
        public void GivenIClickOnTasksOnTheDashboard()
        {
            Assert.True(dashboardPage.SetNewTaskButtonVisible());
            Assert.AreEqual("Terry Teacher", dashboardPage.GetLoggedInFieldName());
            dashboardPage.ClickTasks();
        }
        
        [Given(@"I filter the list by ""(.*)""")]
        public void GivenIFilterTheListBy(string p0)
        {
            if(p0.Equals("All"))
            {
                setTaskPage.ClickAllRadio();
            }
        }
        
        [Given(@"I click on ""(.*)""")]
        public void GivenIClickOn(string p0)
        {
            // Element is visible?
            Assert.True(setTaskPage.TaskInList(p0));
            // Element is visible and then clicked on.
            Assert.True(setTaskPage.ClickListItem(p0));

        }
        
        [Given(@"I click on Task Overview")]
        public void GivenIClickOnTaskOverview()
        {
            // Task Overview is visisble?
            Assert.True(taskPage.TaskOverviewVisible());
            // Click Task Overview
            taskPage.ClickTaskOverview();
        }
        
        [When(@"I Edit the task name to ""(.*)""")]
        public void WhenIEditTheTaskNameTo(string p0)
        {
            // Click Edit
            taskPage.ClickEdit();
            // Check to see if Task Name field is present
            Assert.True(editTaskPage.TaskNameFieldVisisble());
            // Edit Task Name
            editTaskPage.SetTaskName(p0);
            // Save
            editTaskPage.ClickSave();
            // Click View Task on Set Task Screen
            editTaskPage.SetTask_viewTask();
            // Set Global Variable for newTaskName
            newTaskName = p0;
        }
        
        [Then(@"the task name is successfully updated")]
        public void ThenTheTaskNameIsSuccessfullyUpdated()
        {
            // Click Task Overview
            taskPage.ClickTaskOverview();
            // Check task name is correct
            taskPage.ValidateName(newTaskName);
        }
    }
}
