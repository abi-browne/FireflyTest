using TechTalk.SpecFlow;
using FireflyTest.PageObjects;
using NUnit.Framework;

namespace FireflyTest.Specs
{
    [Binding, Scope(Tag = "loginTests")]
    public class CommonStepDefinitions
    {
        private LoginPage loginPage;
        private DashboardPage dashboardPage;
        private Driver driver;

        [BeforeScenario("loginTests")]
        public void Before()
        {
            driver = new Driver();
            loginPage = new LoginPage(driver);
            dashboardPage = new DashboardPage(driver);
        }

        [AfterScenario("loginTests")]
        public void After()
        {
            driver.logout();

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
