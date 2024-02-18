using Microsoft.VisualBasic.FileIO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Assert = Xunit.Assert;

namespace Mars_Application_UserStory2_TestAutomation.Pages
{
    public class SignUpPage
    {

        public void LaunchApplication(IWebDriver driver)
        {
            //Maximize the browser
            driver.Manage().Window.Maximize();

            //Launch Local host Mars applicatio portal and navigate to website login page
            driver.Navigate().GoToUrl("http://localhost:5000/");

            Thread.Sleep(1000);

        }

            public void UserSignUp(IWebDriver driver,string firstname,string lastname,string email,string password,string conpassword)
        {
            IWebElement JoinButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/button"));
            JoinButton.Click();

            Thread.Sleep(2000);

            IWebElement First_name = driver.FindElement(By.Name("firstName"));
            First_name.SendKeys(firstname);

            IWebElement Last_name = driver.FindElement(By.Name("lastName"));
            Last_name.SendKeys(lastname);

            IWebElement Email = driver.FindElement(By.Name("email"));
            Email.SendKeys(email);

            IWebElement PassWord = driver.FindElement(By.Name("password"));
            PassWord.SendKeys(password);

            IWebElement ConfirmPassword = driver.FindElement(By.Name("confirmPassword"));
            ConfirmPassword.SendKeys(conpassword);

            IWebElement CheckBox = driver.FindElement(By.Name("terms"));
            CheckBox.Click();

            IWebElement JoinButton1 = driver.FindElement(By.Id("submit-btn"));
            JoinButton1.Click();

            Thread.Sleep(1000);

            IWebElement test1 = driver.FindElement(By.XPath("//*[@id=\"submit-btn\"]"));
            Assert.True(test1.Displayed);

           // var msg = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]"));
            //Assert.True(msg.Displayed);
            ///html/body/div[5]/div/div/form/div[3]/div
            

        }

    }
}
