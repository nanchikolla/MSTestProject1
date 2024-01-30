namespace MSTestProject1
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

        [TestClass]
        public class UnitTest1
        {
            static IWebDriver driver;

            [TestMethod]
            public void TestWebSiteText()
            {
                string assignedtext = "Welcome Viaan Kolla with your parents!!!";
                System.Console.WriteLine("Hello Guys");
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://dotnetcorewebapp11.azurewebsites.net/");
                String text = driver.FindElement(By.CssSelector("h1")).Text;
                System.Console.WriteLine(text);
                Assert.IsTrue(text.Equals(assignedtext));
                //Assert.Equals(text, assignedtext);
                driver.Close();
            }
        }
}