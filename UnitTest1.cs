using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSearchStreetFighterVThenVerifyStreetFighterVIsDisplayed()
        {
            int waitingTime = 2000;
            By googleSearchBar = By.Name("q");
            By googleSearchButton = By.Name("btnK");
            //By googleResultText = By.XPath(".//h2//div[text()='Street Fighter V']");
            By googleResultText = By.XPath("//div[@class='DoxwDb']");
            //By googleIAgreeButton = By.Id("L2AGLb");

            IWebDriver webDriver = new ChromeDriver();

            Thread.Sleep(waitingTime);

            webDriver.Navigate().GoToUrl("https://www.google.co.uk");

            Thread.Sleep(waitingTime);

            //webDriver.FindElement(googleIAgreeButton).Click();

            webDriver.Manage().Window.Maximize();

            Thread.Sleep(waitingTime);

            webDriver.FindElement(googleSearchBar).SendKeys("Street Fighter V");

            Thread.Sleep(waitingTime);

            webDriver.FindElement(googleSearchButton).Click();

            Thread.Sleep(waitingTime);

            var actualResultText = webDriver.FindElement(googleResultText);

            Assert.IsTrue(actualResultText.Text.Equals("Street Fighter V"));

            webDriver.Navigate().Refresh();
            webDriver.Manage().Window.Minimize();
            
        }
    }
}


