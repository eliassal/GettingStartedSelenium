using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Firefox;
// https://www.codeproject.com/Articles/1217887/Getting-Started-with-Selenium-3-7-using-Visual-Stu?msg=5817931#xx5817931xx
namespace GettingStartedSelenium
{
    [TestClass]
    public class GoogleSearchEngineUsingFirefox
    {
        [TestMethod]
        public void Should_Search_Using_Firefox()
        {
            using (var driver = new FirefoxDriver())
            {
                // 1. Maximize the browser
                driver.Manage().Window.Maximize();

                // 2. Go to the "Google" homepage
                driver.Navigate().GoToUrl("http://www.google.com");

                // 3. Find the search textbox (by ID) on the homepage
                var searchBox = driver.FindElementById("lst-ib");

                // 4. Enter the text (to search for) in the textbox
                searchBox.SendKeys("Automation using selenium 3.0 in C#");

                // 5. Find the search button (by Name) on the homepage
                var searchButton = driver.FindElementByName("btnK");

                // 6. Click "Submit" to start the search
                searchButton.Submit();

                // 7. Find the "Id" of the "Div" containing results stats,
                // located just above the results table.
                var searchResults = driver.FindElementById("resultStats");
            }
        }
    }
}
