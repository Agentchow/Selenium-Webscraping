using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;


class WebScrape
{
    static void Main(string[] args){
        IWebDriver driver = new ChromeDriver (@"C:\Users\chzcho\WebScraping\bin\Debug\netcoreapp2.2");
        //Starts the driver and loads Wiki Tournament Page
        driver.Url = "https://liquipedia.net/counterstrike/S-Tier_Tournaments"; 

        //Creates Objects of Web Elements with Tag Name "b"
        IReadOnlyCollection <IWebElement> tournament = driver.FindElements(By.TagName("b"));

        //Main Loop that controls amount of "link clicks"
        //Change this r value
        for (int r=17; r<tournament.Count; r++)
        {
            foreach(var item in tournament.ElementAt(r).FindElements(By.TagName("a"))) 
            {
                item.GetAttribute("href");
                Console.WriteLine(item.GetAttribute("href"));
                item.Click();

                //Select the Scores in Group Stage
                IReadOnlyCollection <IWebElement> matchRow = driver.FindElements(By.ClassName("bracket-popup-body-match-container"));
                Console.WriteLine(matchRow.Count);  

                for (int z=0; z<matchRow.Count; z++)
                {
                    foreach(var score in matchRow.ElementAt(z).FindElements(By.CssSelector("td[style^='font-size:16px;width:30px']")))
                    {
                        var output = score.GetAttribute("innerHTML");
                        Console.WriteLine(output);



                    }
                }

                driver.Navigate().Back();
                tournament = driver.FindElements(By.TagName("b"));
            }            

        }
        Console.Read();

        driver.Navigate().Back();
        //driver.Quit();
    }
}
