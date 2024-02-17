using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Interactions;
using System;
using static System.Net.Mime.MediaTypeNames;
using Mars_Application_UserStory2_TestAutomation.Pages;


namespace Mars_Application_UserStory2_TestAutomation.Mars_ApplicationStepDefinitions
{
    [Binding]
    public class UserProfileStepDefinitions
    {
        private readonly IWebDriver driver;
        private readonly Login LoginPageObj = new Login();
        private readonly HomePage HomePageObj = new HomePage();
        private readonly ProfilePage ProfilePageObj = new ProfilePage();
        
        public UserProfileStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
           
        }

        //IWebDriver driver = new ChromeDriver();
/*        Login LoginPageObj = new Login();
        HomePage HomePageObj = new HomePage();
        ProfilePage ProfilePageObj = new ProfilePage();*/

        [Given(@"User logs in Mars application using valid username ""([^""]*)"" and password ""([^""]*)""")]
        public void GivenUserLogsInMarsApplicationUsingValidUsernameAndPassword(string username, string password)
        {
            LoginPageObj.LoginActions(driver, username, password);

        }

        [When(@"User selects Profile tab")]
        public void WhenUserSelectsProfileTab()
        {
            HomePageObj.HomePageActions(driver);

        }


        [When(@"User enters new Language details '([^']*)' '([^']*)' and clicks on Add New button")]
        public void AddLanguageDetails(string language, string languageLevel)
        {
            ProfilePageObj.CreateLanguage(driver, language, languageLevel);
        }


        [Then(@"Application saves the Langauge details '([^']*)' '([^']*)' for the user")]
        public void ThenApplicationSavesTheLangaugeDetailsForTheUser(string language, string languageLevel)
        {
            ProfilePageObj.VerifyLanguageDetailsareSaved(driver, language, languageLevel);
        }


        [When(@"User edits language details '([^']*)' '([^']*)' and clicks on update button")]
        public void WhenUserEditsLanguageDetailsAndClicksOnUpdateButton(string language, string language_level)
        {
            ProfilePageObj.EditLanguage(driver, language, language_level);
        }

        [Then(@"Application edits the lanuage details '([^']*)' '([^']*)' for the user")]
        public void ThenApplicationEditsTheLanuageDetailsForTheUser(string language, string language_level)
        {
            ProfilePageObj.VerifyEditLanguage(driver, language, language_level);
        }

        [When(@"User deletes language_details '([^']*)' '([^']*)' for the user")]
        public void WhenUserDeletesLanguage_Details(string language, string language_level)
        {
            ProfilePageObj.DeleteLanguage(driver, language, language_level);
        }


        /*[When(@"User deletes language details")]
        public void WDeletesLanguageDetailsAndClicksOnUpdateButton(string language, string language_level)
        {
            ProfilePageObj.DeleteLanguage(driver, language, language_level);
        }*/

        /*[Then(@"Application deletes the lanuage details '([^']*)' '([^']*)' for user")]
        public void ThenApplicationDeletesTheLanuageDetailsForTheUser(string language, string language_level)
        {
            ProfilePageObj.VerifyDeleteLanguage(driver, language, language_level);
        }*/


        [Then(@"Application deletes the lanuage details '([^']*)' '([^']*)' for the user")]
        public void DeleteLanugaue(string language, string language_level)
        {
            ProfilePageObj.VerifyDeleteLanguage(driver, language, language_level);
        }


        [StepDefinition(@"User enters new skills detais '([^']*)' '([^']*)'and clicks on Add new button")]
        public void GivenUserEntersNewSkillsDetaisAndClicksOnAddNewButton(string skills, string skillLevel)
        {
            ProfilePageObj.CreateSkills(driver, skills, skillLevel);
        }

        [Then(@"Application saves the skills details '([^']*)' '([^']*)'")]
        public void ThenApplicationSavesTheSkillsDetails(string skills, string skillLevel)
        {
            ProfilePageObj.VerifySkillsDetailsareSaved(driver, skills, skillLevel);
        }

        [Then(@"Application saves the skills details '([^']*)''([^']*)' for the user")]
        public void ThenApplicationSavesTheSkillsDetailsForTheUser(string skills, string skill_levels)
        {
            ProfilePageObj.VerifySkillsDetailsareSaved(driver, skills, skill_levels);
        }

        [Given(@"User edits new skills detais '([^']*)' '([^']*)'and clicks on update new button")]
        public void GivenUserEditsNewSkillsDetaisAndClicksOnUpdateNewButton(string skills, string skillLevel)
        {
            ProfilePageObj.EditSkills(driver, skills, skillLevel);
        }

        [When(@"User deletes skills_details '([^']*)' '([^']*)' for the user")]
        public void WhenUserDeletesSkills_DetailsForTheUser(string skills, string skillLevel)
        {
            ProfilePageObj.DeleteSkills(driver, skills, skillLevel);
        }


        [StepDefinition(@"User enters a duplciate Language details '([^']*)' '([^']*)' and clicks on Add New button")]
        public void WhenUserEntersADuplciateLanguageDetailsAndClicksOnAddNewButton(string language, string languageLevel)
        {
            ProfilePageObj.CreateDuplicateLanguage(driver, language, languageLevel);
        }

        [When(@"User enters a duplciate skills details '([^']*)' '([^']*)' and clicks on Add New button")]
        public void WhenUserEntersADuplciateSkillsDetailsAndClicksOnAddNewButton(string skills, string skillLevel)
        {
            ProfilePageObj.CreateDuplicateSkills(driver, skills, skillLevel);
        }

    }
}
