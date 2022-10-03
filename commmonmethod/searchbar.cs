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
       By click_search = By.XPath("/div/header/div/details-modal/details/summary/span/svg[1]");
        By search_type = By.XPath("//input[@id=\'Search-In-Modal\']");
        By click_btn = By.XPath("//*[@id=\'shopify-section-template--16120528011476__main\']/div/div/div/form/div/button");


        public void ForClick()
        {
            btn(click_search);


        }



        /*

        public void search_function(string men)
        {
            btn(click_search);
            Settext(search_type, men);
            Thread.Sleep(8000);
            btn(click_btn);
        }
        */
    }


}
