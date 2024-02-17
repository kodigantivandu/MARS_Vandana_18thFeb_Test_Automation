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
    public class ProfilePage
    {
        public void CreateLanguage(IWebDriver driver, string language, string languageLevel)
        {
            Thread.Sleep(1000);
            IWebElement AddnewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddnewButton.Click();
            Thread.Sleep(2000);

            IWebElement AddLanguage = driver.FindElement(By.Name("name"));
            AddLanguage.SendKeys(language);
            Thread.Sleep(1000);

            IWebElement AddLanguageLevel = driver.FindElement(By.Name("level"));
            SelectElement select = new SelectElement(AddLanguageLevel);
            select.SelectByText(languageLevel);
            Thread.Sleep(1000);

            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            AddButton.Click();

        }

        public void VerifyLanguageDetailsareSaved(IWebDriver driver, string language, string languageLevel)
        {
            // Implement table/row approach to verify languages are saved

            Console.WriteLine("Languages verification to be implmented");

            IWebElement SignOut = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
            SignOut.Click();
        }


        public void EditLanguage(IWebDriver driver, string language, string lenaguage_level)
        {
            Thread.Sleep(1000);
            string tableValue = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td.right.aligned > span:nth-child(1)";
            IWebElement tableData = driver.FindElement(By.CssSelector(tableValue));
            tableData.Click();

            IWebElement LanguageName = driver.FindElement(By.Name("name"));
            LanguageName.Clear();
            LanguageName.SendKeys(language);

            Thread.Sleep(1000);
            IWebElement UpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            UpdateButton.Click();
        }

        public void VerifyEditLanguage(IWebDriver driver, string language, string lenaguage_level)
        {
            IWebElement SignOut = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
            SignOut.Click();
        }

        public void DeleteLanguage(IWebDriver driver, string language, string language_level)
        {
            Thread.Sleep(1000);
            IWebElement LanguageMainTable = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));
            var tableElements = LanguageMainTable.FindElements(By.TagName("tr"));
            var tbRowCount = tableElements.Count;
            if (tbRowCount > 1)
            {
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
                deleteButton.Click();
                Thread.Sleep(1000);
            }
        }

        public void VerifyDeleteLanguage(IWebDriver driver, string language, string language_level)

        {
            IWebElement LanguageMainTable = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));
            var tableElements = LanguageMainTable.FindElements(By.TagName("tr"));
            var tbRowCount = tableElements.Count;
            if (tbRowCount > 1)
            {
                // verify that language is deleted
                IWebElement LanguageTable = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr"));
                var tdElements = LanguageTable.FindElements(By.TagName("td"));

                var languageText = tdElements[0].Text.ToString();
                Assert.False(languageText.Contains(language), $"Languae Delete Failed: Application continues to show {language}");
            }

            IWebElement SignOut = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
            SignOut.Click();

        }


        //Adding Skills code
        public void CreateSkills(IWebDriver driver, string skills, string skillLevel)
        {
            Thread.Sleep(1000);
            IWebElement Skilltab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            Skilltab.Click();

            IWebElement AddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewButton.Click();
            Thread.Sleep(1000);

            IWebElement AddSkills = driver.FindElement(By.Name("name"));
            AddSkills.SendKeys(skills);
            IWebElement AddskillsLevel = driver.FindElement(By.Name("level"));
            AddskillsLevel.SendKeys(skillLevel);

             SelectElement select = new SelectElement(AddskillsLevel);
             select.SelectByText(skillLevel);

             Thread.Sleep(1000);
            IWebElement Addbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            Addbutton.Click();

            Thread.Sleep(1000);

            IWebElement SignOut = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
            //SignOut.Click();
        }


        public void VerifySkillsDetailsareSaved(IWebDriver driver, string language, string languageLevel)
        {
            // Implement table/row approach to verify languages are saved

            Console.WriteLine("Skills  verification to be implmented");
            IWebElement SignOut = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
            SignOut.Click();
        }

        public void EditSkills(IWebDriver driver, string skills, string skill_levels)
        {
            Thread.Sleep(1000);
            
            IWebElement Skilltab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            Skilltab.Click();

            Thread.Sleep(1000);
            string tableValue = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td.right.aligned > span:nth-child(1)";
            IWebElement tableData = driver.FindElement(By.CssSelector(tableValue));
            tableData.Click();


            IWebElement SkillName = driver.FindElement(By.Name("name"));
            SkillName.Clear();
            SkillName.SendKeys(skills +Keys.Tab);
            ////*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]
            //IWebElement UpdateButton = driver.FindElement(By.XPath("*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]"));

            Thread.Sleep(1000);
            IWebElement UpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            UpdateButton.Click();

            IWebElement SignOut = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
            SignOut.Click();
        }

        public void DeleteSkills(IWebDriver driver, string skills, string skill_levels)
        {
            Thread.Sleep(1000);
            IWebElement Skilltab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            Skilltab.Click();
            Thread.Sleep(1000);
            IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
            DeleteButton.Click();

            IWebElement SignOut = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
            SignOut.Click();
        }


        // Extended Positive Tests

        public void CreateDuplicateLanguage(IWebDriver driver, string language, string language_level)

        {
            CreateLanguage(driver, language, language_level);

            // IWebElement banner = 
            Thread.Sleep(500);
            Assert.True(driver.FindElement(By.ClassName("ns-box-inner")).Displayed);
            
            IWebElement SignOut = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
            SignOut.Click();

        }

        public void CreateDuplicateSkills(IWebDriver driver, string skills, string skills_level)

        {
            Thread.Sleep(1000);
            CreateSkills(driver, skills, skills_level);


/*            IWebElement Skilltab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            Skilltab.Click();
            // IWebElement banner = */
            Thread.Sleep(500);
            Assert.True(driver.FindElement(By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-error.ns-show > div")).Displayed);

            IWebElement SignOut = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
            SignOut.Click();

        }

    }
}
