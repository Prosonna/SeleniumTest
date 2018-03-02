using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
        //Create the reference for our browser
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
         

        }
        [SetUp]
        public void Initialize()
        {
            //Navigate to google page
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL");

        }

        [Test]
        public void ExecuteTest()
        {
            /*          //EnterText(element, value, type);

                        //Find the element
                        IWebElement element = driver.FindElement(By.Name("q"));

                        //Perform Ops
                        element.SendKeys("Execute Automation");

                        Console.WriteLine("Executed Test");
             */

            //Title
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            //Initial
            SeleniumSetMethods.EnterText(driver, "Initial", "P.H.N.", "Id");


            //Console.WriteLine("The value from my title is:" + SeleniumGetMethods.GetText(driver, "TitleId", "Id"));

            Console.WriteLine("The value from my initial is: " + SeleniumGetMethods.GetText(driver, "Initial", "Id"));

            //First Name
            //SeleniumSetMethods.EnterText(driver, "FirstName", "Prosonna", "name");

            //Middle Name
            //SeleniumSetMethods.EnterText(driver, "MiddleName", "Hossain", "name");

            //Gender
            //SeleniumSetMethods.Click(driver, "Male", "name");

            //Languages Known
            //SeleniumSetMethods.Click(driver, "english", "name");

            //Click
            SeleniumSetMethods.Click(driver, "Save", "name");
            
        }

        [Test]
        public void Test()
        {
            Console.WriteLine("Executed Test2");
        }


        [TearDown]
        public void CleanUp()
        {
            //driver.Close();

            //Console.WriteLine("Close the browser");
        }
    }
}
