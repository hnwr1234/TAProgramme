﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAProgmme_2.Utilities;

namespace TAProgmme_2.Pages
{
    public class HomePage
    {
         public void NavigateToTMPage(IWebDriver driver)
       
        {
            //Navigate to Time and Material Page 
            IWebElement adminstrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminstrationTab.Click();

            Wait.WaitToBeClickable(driver, "XPath", " /html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 10);
            
            IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMaterialOption.Click();
        }
    }
}
