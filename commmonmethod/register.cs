using commonmethod;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commmonmethod
{
    public class register : commmon_method
    {
        By sign_inbtn = By.XPath("//*[@id='shopify-section-header-men']/div/header/div/a[1]/span[1]");
        By create_act = By.XPath("//*[@id=\'customer_login\']/a[2]");
        By first_name = By.XPath("//input[@id=\'RegisterForm-FirstName\']");
        By last_name = By.XPath("//input[@id=\"RegisterForm-LastName\"]");
        By Emai = By.XPath("//input[@id=\'RegisterForm-email\']");
        By password = By.XPath("//input[@id=\'RegisterForm-password\']");
        By creat_btn = By.XPath("//*[@id=\'create_customer\']/button/text()");
        public register(IWebDriver driver)
        {
            commondriver = driver;
        }

        public void ForClick(By locate)
        {
            btn(locate);


        }


        public void register_functiom(string first_n,string last_n, string email, string pass)
        {
            btn(sign_inbtn);
            ForClick(create_act); 
            Settext(first_name,first_n);
            Settext(last_name, last_n);
            Settext(Emai,email);
            Settext(password,pass);
            btn(creat_btn);




        
        
        
        
        }

    }









}
