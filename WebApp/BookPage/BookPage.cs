using System;
using OpenQA.Selenium;

namespace AutomationDemoTest
{
    class BookPage :CorePage
    {
        #region  
        By fnameTxt=By.Id("first_name");
        By lnameTxt=By.Id("last_name");
        By addressTxt=By.Id("address");
        By cCnoTxt=By.Id("cc_num");
        By cCtypeDropdown=By.Id("cc_type");
        By expiryDateDropDown=By.Id("cc_exp_month");
        By expiryYearDropDown=By.Id("cc_exp_year");
        By cVVNoTxt= By.Id("cc_cvv");
        By bookNowBtn=By.Id("book_now");
        By cancelBtn=By.Id("cancel");
        #endregion
        public void Bookpage()
        {
            // driver.FindElement(fnameTxt).SendKeys("Sohaib");
            // driver.FindElement(lnameTxt).SendKeys("Akhter");
            // driver.FindElement(addressTxt).SendKeys("karachi pakistan hai address");
            // driver.FindElement(cCnoTxt).SendKeys("123456789");
            // driver.FindElement(cCtypeDropdown).SendKeys("Visa");
            // driver.FindElement(expiryDateDropDown).SendKeys("April");
            // driver.FindElement(expiryYearDropDown).SendKeys("2023");
            // driver.FindElement(cVVNoTxt).SendKeys("1234");

            // driver.FindElement(bookNowBtn).Click();
            step=test.CreateNode("BookPage");
            Write(fnameTxt,"Sohaib");
            Write(lnameTxt,"Akhter");
            Write(addressTxt,"karachi pakistan hai address");
            Write(cCnoTxt,"123456789");
            Write(cCtypeDropdown,"Visa");
            Write(expiryDateDropDown,"April");
            Write(expiryYearDropDown,"2023");
            Write(cVVNoTxt,"1234");
            Click(bookNowBtn);
            
        }
    }
}