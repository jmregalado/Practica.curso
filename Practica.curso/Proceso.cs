using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Practica.curso
{
    class Proceso
    {
        ChromeDriver Chrome;

        [SetUp]
        public void StartBrowser()
        {
            Chrome = new ChromeDriver();
            Chrome.Manage().Window.Maximize();
            Chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        [Test]
        public void Offlinesupport()
        {
            
                string Email = "user";
                string Password = "password";


                Chrome.Navigate().GoToUrl("http://plus.certiport.com/plus3/#/login");
                IWebElement EmailElement = Chrome.FindElement(By.XPath("//*[@id='inputUsername']"));
                EmailElement.SendKeys(Email);
                IWebElement PasswordElement = Chrome.FindElement(By.XPath("//*[@id='inputPassword']"));
                PasswordElement.SendKeys(Password);
                

        }
    }
}
