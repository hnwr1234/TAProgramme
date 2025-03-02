using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAProgmme_2.Utilities;

namespace TAProgmme_2.Pages
{
    class TMPage
    {
        public void CreateTimeRecord(IWebDriver driver)
        {
            //Click on Creat New Button 
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a "));
            createNewButton.Click();

            //Select Time from dropdown 
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath(" //*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCodeDropdown.Click();

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();
            Thread.Sleep(2000);


            //Type code into Code textbox  
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("TA Programme");


            //Type description into Description textbox 
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("Medical care");



            //Type Price into Price textbox
            IWebElement priceTagOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTagOverlap.Click();



            IWebElement pricePerUnitTextbox = driver.FindElement(By.Id("Price"));
            pricePerUnitTextbox.SendKeys("12");

            Wait.WaitToBeClickable(driver,"Id","SaveButton",3);

            //Click on Save Button 
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);


            //Check if Time record has been created successfully 
            IWebElement goToTheLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));

            goToTheLastPageButton.Click();
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[2]/td[1]"));

            if (newCode.Text == "TA Programme")
            {
                Console.WriteLine("Time record created successfully!");
            }
            else
            {
                Console.WriteLine("Time record has not been created!");
            }
          }

        public void EditTimeRecord()
        {

        }


        public void DeleteTimeRecord() 
        {
        }

        internal void DeleteTimeRecord(IWebDriver driver)
        {
            throw new NotImplementedException();
        }

        internal void EditTimeRecord(IWebDriver driver)
        {
            throw new NotImplementedException();
        }
    }
    }

