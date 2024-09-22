using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestesAutomatizados.Core
{
    public class Begin : DSL
    {

        #region Verificando Mode Navegador
        private void AbreNavegador()
        {
            var headlessMode = new ChromeOptions();
            headlessMode.AddArgument("window-size=1366x768");
            headlessMode.AddArgument("disk-cache-size=0");
            headlessMode.AddArgument("headless");


            var devMode = new ChromeOptions();
            devMode.AddArgument("disk-cache-size=0");
            devMode.AddArgument("start-maximized");


            if (headlessTest) { driver = new ChromeDriver(headlessMode); }
            else {  driver = new ChromeDriver(devMode); driverQuit = false; }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        
        [SetUp]
        public void InicioTest()
        {
            AbreNavegador();
            driver.Navigate().GoToUrl("https://pt.wikipedia.org/wiki/Wikip%C3%A9dia:P%C3%A1gina_principal");
        }

        
        [TearDown]
        public void FimTest()
        {
            if (driverQuit)
                driver.Quit();
        }

        #endregion TearDown
    }
}