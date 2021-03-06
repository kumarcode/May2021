
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
    [Parallelizable]
    class Program : CommonDriver
    {

        //static void Main(string[] args)
        //{
        //}



        [Test]
        public void CreateTMTest()
        {

            // Create object for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // Create object for TM page
            TMPage tmObj = new TMPage();
            tmObj.CreateTM(driver);

        }

        [Test]
        public void EditTMTest()
        {

            // Create object for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // Create object for TM page
            TMPage tmObj = new TMPage();
            tmObj.EditTM(driver);
        }

        [Test]
        public void DeleteTMTest()
        {

            // Create object for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // Create object for TM page
            TMPage tmObj = new TMPage();
            tmObj.DeleteTM(driver);
        }



    }
}
