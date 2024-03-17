using System;
using OpenQA.Selenium;

namespace AutomationDemoTest
{
    class SearchPage :CorePage
    {
        #region locators
        By locationDropDown=By.Id("location");
        By hotelDropDown=By.Id("hotels");
        By roomTypeDropDown=By.Id("room_type");
        By noOfRoomDropDown=By.Id("room_nos");
        By checkInDateTxt=By.Id("datepick_in");
        By checkOutDate=By.Id("datepick_out");
        By adultPerRoomDropDown=By.Id("adult_room");
        By childrenPerRoomDropDown=By.Id("child_room");
        By searchBtn=By.Id("Submit");
        By resetBtn=By.Id("Reset");
        #endregion
        // public void SearchHotel()
        // {
        //     driver.FindElement(locationDropDown).SendKeys("Sydney");
        //     driver.FindElement(hotelDropDown).SendKeys("Hotel Hervey");
        //     driver.FindElement(roomTypeDropDown).SendKeys("Standard");
        //     driver.FindElement(noOfRoomDropDown).SendKeys("2 - Two");
        //     driver.FindElement(checkInDateTxt).SendKeys("08/07/2021");
        //     driver.FindElement(checkOutDate).SendKeys("09/07/21");
        //     driver.FindElement(adultPerRoomDropDown).SendKeys("2 - Two");
        //     driver.FindElement(childrenPerRoomDropDown).SendKeys("2 - Two");
        //     driver.FindElement(searchBtn).Click();
        // }
         public void SearchHotel()
        {
            step=test.CreateNode("SearchHotel");
            Write(locationDropDown,"Sydney");
            Write(hotelDropDown,"Hotel Hervey");
            Write(roomTypeDropDown,"Standard");
            Write(noOfRoomDropDown,"2 - Two");
            Write(checkInDateTxt,"08/07/2021");
            Write(checkOutDate,"09/07/21");
            Write(adultPerRoomDropDown,"2 - Two");
            Write(childrenPerRoomDropDown,"2 - Two");
            Click(searchBtn); 
        }
    }
}