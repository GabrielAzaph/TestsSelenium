using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V109.WebAudio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tests Selenium!");
            // TEST

            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://github.com/GabrielAzaph");
            if (driver.Url.Contains("GabrielAzaph"))
            {
                //TestingPrintDriver(driver);
                //var dvTSession = driver.GetDevToolsSession();

            }
        }

        private static void TestingPrintDriver(ChromeDriver driver)
        {
            var optionsPrint = new PrintOptions();
            optionsPrint.AddPageToPrint(1);


            var print = driver.Print(optionsPrint);
            var pagePrint = print;

            try
            {
                File.WriteAllBytes(@"C:\Users\Public\Pictures\PrintPage2.jpeg", print.AsByteArray);
            }
            catch (Exception)
            {

            }
        }
    }
}
