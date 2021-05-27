using May2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace May2021.Pages
{
    class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {

            driver.Manage().Window.Maximize();

            // enter url

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            try
            {
                Wait.WaitForElementToBePresent(driver, "Id", "UserName", 2);

                // identify and input username
                IWebElement Username = driver.FindElement(By.Id("UserName"));
                Username.SendKeys("hari");

                // identify and input password
                IWebElement Password = driver.FindElement(By.Id("Password"));
                Password.SendKeys("123123");

                // click login button
                IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                LoginButton.Click();
            }
            catch(Exception ex)
            {
                Assert.Fail("Test failed at login page", ex.Message);
            }

        }
    }
}
