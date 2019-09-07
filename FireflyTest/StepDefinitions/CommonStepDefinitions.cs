using System;
using TechTalk.SpecFlow;
using FireflyTest.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace FireflyTest.Specs
{
    [Binding]
    public class CommonStepDefinitions
    {
        private LoginPage loginPage;
        private DashboardPage dashboardPage;
        private Driver driver;

        [BeforeScenario]
        public void Before()
        {
            driver = new Driver();
            loginPage = new LoginPage(driver);
            dashboardPage = new DashboardPage(driver);
        }

        [AfterScenario]
        public void After()
        {
            if (driver != null)
            {
                driver.Quit(); 
            }
        }

        [Given(@"I have entered a valid UserName and Password")]
        public void GivenIHaveEnteredAValidUserNameAndPassword()
        {
            loginPage.PopulateLogin("tteacher", "spitfire");
        }
        
        [Given(@"I click Login")]
        public void GivenIClickLogin()
        {
            loginPage.ClickLogin();
        }
        
        [Then(@"the Dashboards page will be displayed")]
        public void ThenTheDashboardsPageWillBeDisplayed()
        {
            Assert.True(dashboardPage.SetNewTaskButtonVisible());
            Assert.AreEqual("Terry Teacher", dashboardPage.GetLoggedInFieldName());
        }
    }
}
