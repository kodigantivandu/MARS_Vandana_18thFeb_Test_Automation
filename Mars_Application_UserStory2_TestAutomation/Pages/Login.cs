using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.CommonModels;
using Xunit;


namespace Mars_Application_UserStory2_TestAutomation.Pages
{
    public class Login
    {
        public void LoginActions(IWebDriver driver, string username, string password)
        {
            //Maximize the browser
            driver.Manage().Window.Maximize();

            //Launch Local host Mars applicatio portal and navigate to website login page
            driver.Navigate().GoToUrl("http://localhost:5000/");

            // Click Sign In
            IWebElement SignButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            Thread.Sleep(1000);
            SignButton.Click();

            // Enter Username and Password and Submit
            IWebElement UserName = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            UserName.SendKeys(username);

            IWebElement Password = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            Password.SendKeys(password);

            IWebElement Loginbutton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            Thread.Sleep(1000);
            Loginbutton.Click();

            // Verify Page is loaded -- welcome vandana
          //driver.Quit();
        }
        


            //Identify password textbox and enter valid password
            
    }
}
