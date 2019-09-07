using FireflyTest.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace FireflyTest.StepDefinitions
{
    [Binding, Scope(Tag = "editTaskTests")]
    public class EditTaskSteps
    {
        private LoginPage loginPage;
        private DashboardPage dashboardPage;
        private Driver driver;

        [BeforeScenario("editTaskTests")]
        public void Before()
        {
            driver = new Driver();
            loginPage = new LoginPage(driver);
            dashboardPage = new DashboardPage(driver);
            loginPage.PopulateLogin("tteacher", "spitfire");
            loginPage.ClickLogin();
        }

        [AfterScenario("editTaskTests")]
        public void After()
        {
            driver.logout();

            if (driver != null)
            {
                driver.Quit();
            }
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
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I click on ""(.*)""")]
        public void GivenIClickOn(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I click on Task Overview")]
        public void GivenIClickOnTaskOverview()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I Edit the task name to ""(.*)""")]
        public void WhenIEditTheTaskNameTo(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the task name is successfully updated")]
        public void ThenTheTaskNameIsSuccessfullyUpdated()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
