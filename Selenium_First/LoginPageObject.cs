using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_First
{
    class LoginPageObject
    {
        [Obsolete]
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        [Obsolete]
        public EAPageObject Login(string username,string password)
        {
            //UserName
            txtUserName.SendKeys(username);
            //Password
            txtPassword.SendKeys(password);
            //Click
            btnLogin.Submit();
            //return a page  object
            return new EAPageObject();


        }
    }
}
