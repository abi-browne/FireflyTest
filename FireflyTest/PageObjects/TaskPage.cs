using OpenQA.Selenium;
using System.Threading;

namespace FireflyTest.PageObjects
{
    class TaskPage
    {
        private Driver driver;

        public TaskPage(Driver driver)
        {
            this.driver = driver;
        }

        By loc_taskOverviewButton = By.CssSelector("#task-overview");
        By loc_editButton = By.XPath("//*[@data-testid='edit']");
        By loc_taskName = By.XPath("//*[@data-testid='title']");

        public bool TaskOverviewVisible()
        {
            return driver.FindElement(loc_taskOverviewButton).Displayed;
        }

        public void ClickTaskOverview()
        {
            driver.FindElement(loc_taskOverviewButton).Click();
        }

        public void ClickEdit()
        {
            driver.FindElement(loc_editButton).Click();
        }

        public bool ValidateName(string name)
        {
            if (driver.FindElement(loc_taskName).Text.Equals(name)) {
                return true;
            } else {
                return false;
            }
        }
    }
}