using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Edge;

namespace commonmethod
{
    [TestClass]
    public class Automation:commmon_method
    {
        public TestContext instance;
        public TestContext TestContext
        {

            set { instance = value; }
            get { return instance; }

        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML","login.xml", "login", DataAccessMethod.Sequential)]
        public void loginbutton()
        {
            IWebDriver adriver = SeleniumInit("EdgeDriver");
           // IWebDriver adriver = new EdgeDriver();
            adriver.Manage().Window.Maximize();
            adriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            adriver.Url = " https://www.beyondeast.com/pages/women";
           
           // string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
           
            login Ol = new login(adriver);
           
            Ol.fortext(user,pass);

        }

    }
}