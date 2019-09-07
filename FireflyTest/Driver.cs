using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

public class Driver
{
    private IWebDriver driver;

    public Driver()
    {
        driver = new ChromeDriver();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        driver.Navigate().GoToUrl("https://fireflyautotest.staging.fireflysolutions.co.uk/");
    }

    public void Quit()
    {
        driver.Quit();
    }

    public IWebElement findElement(By by)
    {
        return driver.FindElement(by);
    }
}