using OpenQA.Selenium;

namespace AgoraVai
{
    public class SeleniumBucasCEP: SeleniumBegin
    {

        [Test]
        public void Test()
        {
            
            driver.FindElement(By.Name("search_query")).SendKeys("Exterminador descolado");
            driver.FindElement(By.Id("search-icon-legacy")).Submit();

            Assert.That(driver.FindElement(By.XPath("//*[@id=\"video-title\"]/yt-formatted-string")).Text, Does.Contain("EXTERMINADOR DESCOLADO 🤪 | (Demon Slayer) | Prod. Sidney Scaccio | MHRAP"));
        }
    }
}