using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Selenium_First
{   
    [TestFixture]
    class Program
    {

        
    
        static void Main(string[] args)
        {
        


        }
        
        [SetUp]
        public void Initialize()
        {   //Create the reference for our browser
            PropertiesCollection.driver = new ChromeDriver();
            //Navigate to Execute Automation Demo Page
            //PropertiesCollection.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/Login.html");
            Console.WriteLine("Opened URL");

        }
        [Test]
        [Obsolete]
        public void ExecuteTest()
        {
            //Login to Application
            LoginPageObject pageLog = new LoginPageObject();
           EAPageObject pageEA= pageLog.Login("execute", "automation");
            pageEA.FillUserForm("kk","Karthik","automation");
            //Initialize the page by calling its reference
           // EAPageObject page = new EAPageObject();
            //pageEA.ddlTitleID.SendKeys("executeautomation");
            //pageEA.btnSave.Click();
            ////Title
            //SeleniumSetMethods.SelectDropDown("TitleId","Mr.",PropertyType.Id);
            ////Initial   
            //SeleniumSetMethods.EnterText("Initial", "executeautomation",PropertyType.Name);
            ////Get the Title ID
            //Console.WriteLine("The value fromr my Title is: "+ SeleniumGetMethods.GetTextfromDDL("TitleId",PropertyType.Id));
            ////Get Initial
            //Console.WriteLine("The value fromr my Initial is: " + SeleniumGetMethods.GetText("Initial",PropertyType.Name));
            ////Click
            //SeleniumSetMethods.Click("Save",PropertyType.Name);
        }

        [Test]
        public void NextTest()
        {
        
            Console.WriteLine("Next method");

        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }

}
