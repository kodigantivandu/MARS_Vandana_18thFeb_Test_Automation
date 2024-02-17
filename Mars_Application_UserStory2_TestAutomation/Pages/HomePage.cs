using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Mars_Application_UserStory2_TestAutomation.Pages
{
    public class HomePage
    {
        public void HomePageActions(IWebDriver driver)
        {
            //Navigate to profile tab
            Thread.Sleep(3000);
            IWebElement ProfileUser = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
            ProfileUser.Click();

            //Verify Profile>Language tab is displayed 
            Thread.Sleep(1000);
            IWebElement LanguageTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            Xunit.Assert.True(LanguageTab.Displayed);
        }



    }
}
