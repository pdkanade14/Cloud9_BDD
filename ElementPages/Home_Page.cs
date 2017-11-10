using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud9_BDD.ElementPages
{
   public class Home_Page
    {
       private readonly IWebDriver browser;

        public Home_Page(IWebDriver browser)
        {
            this.browser = browser;
        }
        
        [FindsBy(How = How.XPath, Using = ".//*[@id='login-form:email']")]
        public IWebElement HP_Email { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='login-form:password']")]
        public IWebElement HP_Password { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='login-form:login']")]
        public IWebElement HP_Login { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='login-form:signup']")]
        public IWebElement HP_SignUp { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='logout-form']/div[2]/label")]
        public IWebElement HP_Name { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='logout-form:details']")]
        public IWebElement HP_Details { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='logout-form:logout']")]
        public IWebElement HP_Logout { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='content']/h1")]
        public IWebElement HP_Name_DetailsPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='content']/div[1]")]
        public IWebElement HP_User_Details { get; set; }
        




        public void UserLogin(string email, string passwood)
        {
            HP_Email.SendKeys(email);
            HP_Password.SendKeys(passwood);
            HP_Login.Click();
        }

    }
}
