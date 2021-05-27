using May2021.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace May2021.Utilities
{
    class CommonDriver
    {
        // init webdriver
        public IWebDriver driver;

        [OneTimeSetUp]
        public void LoginToTurnUp()
        {
            // launch chrome browser
            driver = new ChromeDriver(@"S:\May2021\May2021\");

            // Create object for login page
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);

        }

        [OneTimeTearDown]
        public void TestClosure()
        {
            // closing down steps
            driver.Quit();
        }
    }
}
