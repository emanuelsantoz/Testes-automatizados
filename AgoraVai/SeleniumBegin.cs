using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AgoraVai
{
    public class SeleniumBegin
    {
        public IWebDriver driver;
        public bool driverQuit = true;

        [SetUp]
        public void InicioTest()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.youtube.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driverQuit = false;
        }
   
        [TearDown]
        public void FimTest()
        {
            if (driverQuit) 
                driver.Quit();
            
            
        }
    }
}