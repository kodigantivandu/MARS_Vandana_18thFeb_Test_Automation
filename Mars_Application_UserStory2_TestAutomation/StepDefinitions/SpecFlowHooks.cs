using BoDi;
using Mars_Application_UserStory2_TestAutomation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

[Binding]
public class SpecFlowHooks
{
    private static IWebDriver driver;
    private static Login LoginPageObj;
    private static HomePage HomePageObj;
    private static ProfilePage ProfilePageObj;

    [BeforeTestRun]
    public static void BeforeTestRun()
    {
        if (driver == null)
        {
            driver = new ChromeDriver();
        }

        Login LoginPageObj = new Login();
        HomePage HomePageObj = new HomePage();
        ProfilePage ProfilePageObj = new ProfilePage();

    }

    [AfterTestRun]
    public static void AfterTestRun()
    {
        if (driver != null)
        {
            driver.Quit();
            driver = null;
        }
    }

    [BeforeScenario]
    public void BeforeScenario()
    {
        var scenarioContainer = ScenarioContext.Current.ScenarioContainer;
        scenarioContainer.RegisterInstanceAs(driver);
    }
}
