using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;

namespace Demo.SeleniumTests
{
    [TestClass]
    public class DotNetSiteTests
    {
        [TestMethod]
        public void TestGetStarted()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            using (var driver= new ChromeDriver(chromeOptions))
                {

                driver.Navigate().GoToUrl("https://dotnet.microsoft.com/");
                driver.FindElement(By.LinkText("Get Started")).Click();

                IWebElement nextLink = null;
                do
                {
                    nextLink?.Click();
                    nextLink = driver.FindElements(By.CssSelector(".step:not([style='display:none;']):not([style='display: none;']) .step-select")).FirstOrDefault();
                } while (nextLink != null);

                // on the last step, grab the title of the step wich should be equal to "Next steps"
                var lastStepTitle = driver.FindElement(By.CssSelector(".step:not([style='display:none;']):not([style='display: none;']) h2")).Text;

                // verify the title is the expected value "Next steps"
                Assert.AreEqual(lastStepTitle, "Next steps");

            }
        }
    }
}
