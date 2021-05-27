using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace May2021.Pages
{
    class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // Test 1 - create time/ material record successfully
        }

        public void EditTM(IWebDriver driver)
        {
            // Test 2 - edit time/ material record successfully
            // go to last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(1000);

            // click edit on the last record that was created in the previous test
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]")).Click();
            Thread.Sleep(1000);

            // update from material to time
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]")).Click();
            Thread.Sleep(1000);

            // update code
            driver.FindElement(By.XPath("//*[@id='Code']")).Clear();
            driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("UpdatedCode");
            Thread.Sleep(1000);

            // update description
            driver.FindElement(By.XPath("//*[@id='Description']")).Clear();
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("UpdatedDescription");
            Thread.Sleep(1000);

            // update price - clear
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Clear();
            driver.FindElement(By.XPath("//*[@id='Price']")).Clear();
            Thread.Sleep(1000);

            // update price - input/update
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='Price']")).SendKeys("55");
            Thread.Sleep(1000);

            // upload a doc
            driver.FindElement(By.XPath("//*[@id='files']")).SendKeys(@"S:\May2021\May2021\uploadDoc.txt");
            Thread.Sleep(1000);

            // save
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();
            Thread.Sleep(3000);

            // validate if the record is updated successfully

            // go to last page 
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(1000);

            // identify the updated record 
            string actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text;
            Thread.Sleep(1000);

            // verify the updated details - option 1 
            if (actualCode == "UpdatedCode")
            {
                Assert.Pass("Record edited successfully, Test Passed");
            }
            else
            {
                Assert.Fail("Test Failed");
            }

            // verify the updated details - option 2
            Assert.That(actualCode, Is.EqualTo("UpdatedCode"), "Test Failed");
        }

        public void DeleteTM(IWebDriver driver)
        {
            // Test 3 - delete time/ material record successfully
        }
    }
}
