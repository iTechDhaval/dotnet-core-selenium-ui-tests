using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UITests
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://code.visualstudio.com/");
        }

        [Test]
        public void TestTitle()
        {
            String title = driver.Title;
            System.Console.WriteLine("title of site is : " + title);
            IWebElement button = driver.FindElement(
                    By.CssSelector(".link-button.dlink")
                );
            Assert.AreEqual("Download for Mac\nStable Build" , button.Text);
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}