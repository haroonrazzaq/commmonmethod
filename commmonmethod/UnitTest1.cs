﻿using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;

namespace commonmethod
{

    public class commmon_method
    {

        public IWebDriver commondriver;
        Actions actions;
       
        //driver initialization
        public IWebDriver SeleniumInit(string browser)

        {
            if (browser =="ChromeDriver")
            {
                commondriver = new ChromeDriver();

            }
            else if (browser=="EdgeDriver")
            {
                commondriver =new EdgeDriver();
            }

            return commondriver;

        }

       
        //Find Element 

        public IWebElement FindElement(By Locate)
        {
            return commondriver.FindElement(Locate);
        }


        //Set Text In Element
        public void Settext(By locate, string text)

        {
            IWebElement findedelement1 = FindElement(locate);
            findedelement1.SendKeys(text + Keys.Tab);


        }

        public void btn(By locate)
        {
            actions = new Actions(commondriver);
            actions.Click(FindElement(locate)).Build().Perform();

        }



    }
}