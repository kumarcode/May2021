
using May2021.Pages;
using May2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace May2021
{
    [TestFixture]
    class Program : CommonDriver
    {

        //static void Main(string[] args)
        //{
        //}

        [SetUp]
        public void LoginToTurnUp()
        {
            // launch chrome browser
            driver = new ChromeDriver(@"S:\May2021\May2021\");

            // Create object for login page
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);

            // Create object for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);
        }

        [Test]
        public void CreateTMTest()
        {
            // Create object for TM page
            TMPage tmObj = new TMPage();
            tmObj.CreateTM(driver);

        }

        [Test]
        public void EditTMTest()
        {
            // Create object for TM page
            TMPage tmObj = new TMPage();
            tmObj.EditTM(driver);
        }

        [Test]
        public void DeleteTMTest()
        {
            // Create object for TM page
            TMPage tmObj = new TMPage();
            tmObj.DeleteTM(driver);
        }

        [TearDown]
        public void TestClosure()
        {
            // closing down steps
            driver.Quit();
        }

    }
}
