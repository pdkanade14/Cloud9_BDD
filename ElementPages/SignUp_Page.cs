using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Cloud9_BDD.ElementPages
{
    class SignUp_Page
    {
        private readonly IWebDriver browser;

        public SignUp_Page(IWebDriver browser)
        {
            this.browser = browser;
        }

        [FindsBy(How = How.XPath, Using = ".//*[@id='content-main']/h1")]
        public IWebElement SP_Page_Header { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='signup']/fieldset/legend")]
        public IWebElement SP_Form_Label { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='BirthDate']")]
        public IWebElement SP_Bday_txt { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ext-gen4']")]
        public IWebElement SP_Bday_Calendar { get; set; }


        [FindsBy(How = How.XPath, Using = ".//*[@id='signup:email']")]
        public IWebElement SP_Email_Address { get; set; }

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
