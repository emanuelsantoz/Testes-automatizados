using OpenQA.Selenium;

namespace TestesAutomatizados.Core
{
    public class DSL : GlobalVariables
    {
        public void EscrevaTexto(string xpath, string texto)
        {
            driver.FindElement(By.XPath($"{xpath}")).SendKeys($"{texto}");
        }
        
        public void CliqueElement(string xpath)
        {
            driver.FindElement(By.XPath(xpath)).Submit();
        }
        
        public void VerifiqueHaTexto(string xpath, string text)
        {
            Assert.That(driver.FindElement(By.XPath(xpath)).Text,
                Does.Contain(text));
        }
    }
}
