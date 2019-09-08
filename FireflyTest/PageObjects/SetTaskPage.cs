using OpenQA.Selenium;
using System.Collections.Generic;
using System.Threading;

namespace FireflyTest.PageObjects
{
    class SetTaskPage
    {
        private Driver driver;

        public SetTaskPage(Driver driver)
        {
            this.driver = driver;
        }

        By loc_filterAllRadio = By.CssSelector("#task-filter-status-All-0");
        By loc_taskList = By.XPath("//*[@data-testid='task-title-read']");
        By loc_nextButton = By.XPath("//*[@data-testid='pagination-next']");

        public void ClickAllRadio()
        {
            // Click the All Button
            driver.FindElement(loc_filterAllRadio).Click();
        }

        public bool TaskInList(string name)
        {
            IWebElement taskName = GetListItem(name);
            if(taskName != null) {
                return true;
            } else {
                return false;
            }
        }

        public bool ClickListItem(string name)
        {
            IWebElement taskName = GetListItem(name);
            if (taskName != null)
            {
                taskName.Click();
                return true;
            }
            else
            {
                return false;
            }
        }

        private IWebElement GetListItem(string name)
        {
            bool notDone = true;
            while (notDone)
            {
                if(driver.FindElement(loc_nextButton).Enabled)
                {
                    Thread.Sleep(2500);

                    IReadOnlyCollection<IWebElement> elementsList = driver.FindElements(loc_taskList);

                    foreach (IWebElement taskName in elementsList)
                    {
                        if (taskName.GetAttribute("text").Equals(name))
                        {
                            return taskName;
                        }
                    }
                } else
                {
                    notDone = false;
                }
                driver.FindElement(loc_nextButton).Click();
            }
            return null;     
        }
    }
}