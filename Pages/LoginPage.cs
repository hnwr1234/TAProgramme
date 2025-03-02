using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TAProgmme_2.Utilities;

namespace TAProgmme_2.Pages
{
    class LoginPage
    {
        //Function that allow users to login to TurnUp portal
        public void LoginActions(IWebDriver driver)
        {
            //Launch Turnup portal 
            driver.Navigate().GoToUrl("http://horse.industryconnect.io");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("UserName")));

            //Identify username textbox and enter valid username 
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            Wait.WaitToBeVisible(driver, "Id", "Password", 7);


            //Identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            //Identify login button and click on it 
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(2000);
        }
    }
}
