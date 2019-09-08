using OpenQA.Selenium;

namespace FireflyTest.PageObjects
{
    class EditTaskPage
    {
        private Driver driver;

        public EditTaskPage(Driver driver)
        {
            this.driver = driver;
        }

        By loc_taskNameField = By.XPath("//*[@name='task.title']");
        By loc_saveTaskButton = By.XPath("//*[@data-testid='save-changes']");

        By loc_taskSetViewTaskButton = By.XPath("//*[@data-testid='view-task']");

        public bool TaskNameFieldVisisble()
        {
            return driver.FindElement(loc_taskNameField).Displayed;
        }

        public void SetTaskName(string name)
        {
            // Do a Ctrl-A
            driver.FindElement(loc_taskNameField).SendKeys(Keys.Control + "a");
            // Enter New Name
            driver.FindElement(loc_taskNameField).SendKeys(name);
        }

        public void ClickSave()
        {
            driver.FindElement(loc_saveTaskButton).Click();
        }

        public void SetTask_viewTask()
        {
            driver.FindElement(loc_taskSetViewTaskButton).Click();
        }
    }
}