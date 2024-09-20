using OpenQA.Selenium;

namespace TestesAutomatizados.Core
{
    public class GlobalVariables
    {
        public IWebDriver driver;
        public bool driverQuit = true;
        public bool headlessTest = false;
    }
}
