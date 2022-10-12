using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Edge;
using commmonmethod;

namespace commonmethod
{
        [TestClass]
        public class Automation:commmon_method
        {
            //public TestContext instance;
            //public TestContext TestContext
            //{

            //    set { instance = value; }
            //    get { return instance; }

            //}

       /* [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "drivern.xml", "login", DataAccessMethod.Sequential)]
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

            Ol.fortext(user, pass);
            




        }
        */
        
        //For Click on Search Field

/*        [TestMethod]

         public void SearchCick() 
        {
            IWebDriver adriver = SeleniumInit("EdgeDriver");
            adriver.Manage().Window.Maximize();
            adriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            adriver.Url = " https://www.beyondeast.com/pages/women";
           
            searchbar sb = new searchbar(adriver);
            sb.search_function("Mens");

        }*/


        [TestMethod]

        public void register()
        {
            IWebDriver adriver = SeleniumInit("EdgeDriver");
            adriver.Manage().Window.Maximize();
            adriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            adriver.Url = " https://www.beyondeast.com/pages/women";
            register reg = new register(adriver);
            string f = "Muhammad";
            string l = "Haroon";
            string e = "haroonbhatt420@gmail.com";
            string pas = "bhattiboy@1";
            reg.register_functiom(f,l,e,pas);

        }





    }
}