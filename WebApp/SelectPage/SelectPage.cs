using System;
using OpenQA.Selenium;
using System.Collections.ObjectModel;


namespace AutomationDemoTest
{
    class SelectPage :CorePage
    {
      #region locators
      By selectRadionBtn=By.Id("radiobutton_0");
      By continueBtn=By.Id("continue");
      By cancelBtn=By.Id("cancel");
      #endregion
      public void SelectHotel()
      {
        step=test.CreateNode("SelectPage");
        // driver.FindElement(selectRadionBtn).Click();
        // driver.FindElement(continueBtn).Click();
        Click(selectRadionBtn);
        Click(continueBtn);
      }
    }
}