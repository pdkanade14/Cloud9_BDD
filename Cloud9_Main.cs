using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using Cloud9_BDD.ElementPages;
using System.Configuration;

namespace Cloud9_BDD
{
   
    public class Cloud9_Main
    {
        private readonly IWebDriver brower;
        public IWebDriver driver { get; set; }
        public Cloud9_Main(IWebDriver browser)
        {
            this.brower = browser;
        }

        public Home_Page Map
        {
            get
            {
                return new Home_Page(this.brower);
            }
        }


        public void Navigate()
        {
            this.brower.Navigate().GoToUrl(ConfigurationSettings.AppSettings.Get("URL"));
            this.brower.Manage().Window.Maximize();
        }
 
    }
}
