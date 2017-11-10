using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using Cloud9_BDD.ElementPages;

namespace Cloud9_BDD.TestScripts
{
    [TestFixture]
    class Login
    {
        public IWebDriver driver { get; set; }

        [SetUp]
        public void Setup()
        {
            this.driver = new ChromeDriver();
            Cloud9_Main cm = new Cloud9_Main(this.driver);
            cm.Navigate();
            
        }
        [TearDown]
        public void Teardown()
        {
            //this.driver.Quit();
        }

        [Test]
        public void Login_with_valid_credentials()
        {
            Home_Page hp = new Home_Page(this.driver);
            PageFactory.InitElements(driver, hp);
            hp.UserLogin(ConfigurationManager.AppSettings.Get("email"), ConfigurationManager.AppSettings.Get("password"));
            string name = hp.HP_Name.Text;
            Assert.AreEqual("Prasad Kanade", name);
        }
    }
}
