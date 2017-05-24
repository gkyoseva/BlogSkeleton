using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Tests.Tests;

namespace Block.UI.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void LoadPage()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            driver.Navigate().GoToUrl(@"http://localhost:60634/Article/List");

            var logo = wait.Until(w => w.FindElement(By.XPath("/html/body/div[1]/div/div[1]/a")));

            //var logo = wait.Until(w => w.FindElement(By.ClassName("navbar - brand")));

            Assert.AreEqual("SOFTUNI BLOG", logo.Text);
        }
    }
}
