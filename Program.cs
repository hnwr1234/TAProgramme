using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TAProgmme_2.Pages;
public class Program
{
    private static void Main(string[] args)
    {
        //Open Chrome Browser 
        IWebDriver driver = new ChromeDriver();

        //Implicit Wait
        WebDriverWait wait = new(driver, TimeSpan.FromSeconds(10));

        //Login page object initializaion and definition 
        LoginPage loginPageObj = new();
        loginPageObj.LoginActions(driver);

        //Home page object initialization and definition 
        HomePage homePageObj = new();
        homePageObj.NavigateToTMPage(driver);

        //TM page object initization and definition
        TMPage tMPageObj = new();
        tMPageObj.CreateTimeRecord(driver);

        //Edit Time Record
        tMPageObj.EditTimeRecord(driver);

        //Delete Time Record 
        tMPageObj.DeleteTimeRecord(driver);
    }
}