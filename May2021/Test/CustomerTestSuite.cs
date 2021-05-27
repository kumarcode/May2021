
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
    class CustomerTestSuite : CommonDriver
    {

        //static void Main(string[] args)
        //{
        //}



        [Test]
        public void CreateCompanyTest()
        {

            // Create object for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToCompany(driver);

            // Create object for Company page
            CompanyPage companyObj = new CompanyPage();
            companyObj.CreateCompany(driver);

        }

        [Test]
        public void EditCompanyTest()
        {

            // Create object for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToCompany(driver);

            // Create object for Company page
            CompanyPage companyObj = new CompanyPage();
            companyObj.EditCompany(driver);
        }

        [Test]
        public void DeleteTMTest()
        {

            // Create object for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToCompany(driver);

            // Create object for Company page
            CompanyPage companyObj = new CompanyPage();
            companyObj.DeleteCompany(driver);
        }



    }
}
