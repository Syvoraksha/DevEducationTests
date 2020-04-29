﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTests
{
    public class BaseDriver
    {
     
        public IWebDriver driver;

        [SetUp]

        public void StartBrowser()
        {
            driver = new ChromeDriver("D:\\");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
        
        [TearDown]

        public void CloseBrowser()
        {
            driver.Close();
        }
    }

}
