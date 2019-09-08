using OpenQA.Selenium;

namespace FireflyTest.PageObjects
{
    class DashboardPage
    {
        private Driver driver;

        public DashboardPage(Driver driver)
        {
            this.driver = driver;
        }

        By loc_SetANewTaskButton = By.XPath("//*[@data-testid='set-a-new-task']");
        By loc_LoggedInNameField = By.XPath("//*[@data-testid='terry-teacher']");
        By loc_TaskButton = By.CssSelector(".ff-mainnav-tasks > a:nth-child(1)");

        public bool SetNewTaskButtonVisible()
        {
            return driver.FindElement(loc_SetANewTaskButton).Displayed;
        }

        public string GetLoggedInFieldName()
        {
            return driver.FindElement(loc_LoggedInNameField).GetAttribute("aria-label");
        }

        public void ClickTasks()
        {
            driver.FindElement(loc_TaskButton).Click();
        }
    }
}