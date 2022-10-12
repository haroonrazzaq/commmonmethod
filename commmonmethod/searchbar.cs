using commonmethod;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
namespace commmonmethod
{
    public class searchbar : commmon_method
    {
       By click_search = By.XPath("//*[@id=\'shopify-section-header-men\']/div/header/div/details-modal/details/summary/span/span");
        By search_type = By.XPath("//input[@id=\'Search-In-Modal\']");
        By click_btn = By.XPath("//*[@id=\'shopify-section-template--16120528011476__main\']/div/div[1]/div/form/div/button");


        public void ForClick(By locate)
        {
            btn(locate);


        }
        public searchbar(IWebDriver driver)
        {
            commondriver = driver;
        }




        public void search_function(string men)
        {
            ForClick(click_search);
            Settext(search_type,men);
            Thread.Sleep(5000);
            ForClick(click_btn);
        }
        
    }


}
