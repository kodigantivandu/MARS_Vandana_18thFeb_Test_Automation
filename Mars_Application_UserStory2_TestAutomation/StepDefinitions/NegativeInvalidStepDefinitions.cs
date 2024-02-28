using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Interactions;
using System;
using static System.Net.Mime.MediaTypeNames;
using Mars_Application_UserStory2_TestAutomation.Pages;
using TechTalk.SpecFlow.Assist;
using Assert = Xunit.Assert;

namespace Mars_Application_UserStory2_TestAutomation.StepDefinitions
{
    [Binding]
    public class NegativeInvalidStepDefinitions
    {
        private readonly IWebDriver driver;
        private readonly SignUpPage SignUpPageObj = new SignUpPage();
        private readonly Login LoginPageObj = new Login();

        public NegativeInvalidStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;

        }

        [When(@"the user enters '([^']*)' '([^']*)'  without @ in the Email field")]
        public void WhenTheUserEntersWithoutInTheEmailField(string username, string password)
        {
            LoginPageObj.LoginActions(driver, username, password);
        }

        [When(@"the user '([^']*)' '([^']*)' without \.com in the Email field")]
        public void WhenTheUserWithout_ComInTheEmailField(string username, string password)
        {
            LoginPageObj.LoginActions(driver, username, password);
        }

        [When(@"the user '([^']*)' '([^']*)' and leaves the Email field empty")]
        public void WhenTheUserAndLeavesTheEmailFieldEmpty(string username, string password)
        {
            LoginPageObj.LoginActions(driver, username, password);
        }


        [When(@"the user enters '([^']*)' '([^']*)' and leaves the password field empty")]
        public void WhenTheUserEntersAndLeavesThePasswordFieldEmpty(string username, string password)
        {
            LoginPageObj.LoginActions(driver, username, password);
        }
    }
}