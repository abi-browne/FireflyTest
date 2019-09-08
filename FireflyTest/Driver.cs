using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

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

    public IWebElement FindElement(By by)
    {
        return driver.FindElement(by);
    }

    public IReadOnlyCollection<IWebElement> FindElements(By by)
    {
        return driver.FindElements(by);
    }

    public void logout()
    {
        driver.Navigate().GoToUrl("https://fireflyautotest.staging.fireflysolutions.co.uk/logout");
    }    
}