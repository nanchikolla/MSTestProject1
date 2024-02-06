using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace MSTestProject1
{
        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void TestWebSiteText()
            {
                string assignedtext = "Welcome Viaan Kolla with your parents!!!";
                System.Console.WriteLine("Hello Guys!");
                System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", "chromedriver.exe");
                IWebDriver driver = new ChromeDriver("C:\\Projects\\webapps\\ChromeBrowserTesting\\bin\\Debug\\net6.0"); //<-Add your path
                driver.Navigate().GoToUrl("https://dotnetcorewebapp11.azurewebsites.net/");
                String text = driver.FindElement(By.CssSelector("h1")).Text;
                Assert.IsTrue(text.Equals(assignedtext));
                driver.Close();
            }
        }
}