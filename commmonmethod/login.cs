using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace commonmethod
{
    public class login : commmon_method

    {
        // #region object

        By sign_inbtn = By.XPath("//*[@id='shopify-section-header-men']/div/header/div/a[1]/span[1]");
        By email = By.XPath("//input[@id='CustomerEmail']");
        By passwrd = By.XPath("//input[@id='CustomerPassword']");
        By button = By.XPath("//button[contains(text(),'Sign in')]");
        By Button1 = By.XPath("//input[@type='submit']");

        //#region construction
        public login(IWebDriver driver)
        {
            commondriver = driver;
        }




        //public void button





        public void ForClick(By locate)
        {
            btn(locate);

           
        }



        public void fortext(string username_email , string username_password)
        {
            ForClick(sign_inbtn);
            Settext(email, username_email);
            Settext(passwrd, username_password);
            ForClick(button);
            Thread.Sleep(12000);
            ForClick(Button1);
        }

    }
}