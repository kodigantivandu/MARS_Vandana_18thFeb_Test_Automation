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
    public class NegativeValidStepDefinitions
    {
        private readonly IWebDriver driver;
        private readonly SignUpPage SignUpPageObj = new SignUpPage();
        private readonly Login LoginPageObj = new Login();

        public NegativeValidStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;

        }

        [Given(@"User launches Mars application")]
        public void GivenUserLaunchesMarsApplication()
        {
            SignUpPageObj.LaunchApplication(driver);
        }


        [Given(@"New user clicks join button")]
        public void GivenNewUserClicksJoinButton()
        {
            Console.WriteLine("To be impelemented");
        }

        [When(@"Enters all required details")]
        public void WhenEntersAllRequiredDetails(Table table)
        {
            var userInformation = table.CreateInstance<UserInformation>();
            var firstName = userInformation.First_Name;
            var lastName = userInformation.Last_Name;
            var emailID = userInformation.Email_Address;
            var password = userInformation.Password;
            var confirmPassword = userInformation.Confirm_Password;

            SignUpPageObj.UserSignUp(driver, firstName, lastName, emailID, password, confirmPassword);

        }



        [When(@"User enters valid '([^']*)' '([^']*)' field characters more than six characters")]
        public void WhenUserEntersValidFieldCharactersMoreThanSixCharacters(string username, string password)
        {
            LoginPageObj.LoginActions(driver, username, password);
            Thread.Sleep(1000);
            var msg = driver.FindElement(By.CssSelector("#submit-btn"));
            Assert.True(msg.Displayed);
        }
    }

    //class used to map table
    class UserInformation
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email_Address { get; set; }
        public string Password { get; set; }
        public string Confirm_Password { get; set; }

    }
}
