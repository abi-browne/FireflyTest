using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FireflyTest.PageObjects
{
    class LoginPage
    {
        private Driver driver;

        public LoginPage(Driver driver)
        {
            this.driver = driver;
        }

        By loc_UserNameField = By.CssSelector("#username");
        By loc_PasswordField = By.CssSelector("#password");
        By loc_LoginButton = By.CssSelector(".ff-login-submit");

        public void PopulateLogin(string user, string pwd)
        {
            // Clear and Populate the User Name Field
            driver.findElement(loc_UserNameField).Clear();
            driver.findElement(loc_UserNameField).SendKeys(user);

            // Clear and Populate the Password Field
            driver.findElement(loc_PasswordField).Clear();
            driver.findElement(loc_PasswordField).SendKeys(pwd);
        }

        public void ClickLogin()
        {
            // Click the Login Button
            driver.findElement(loc_LoginButton).Click();
        }
    }
}