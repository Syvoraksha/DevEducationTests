using DevEducationTests.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevEducationTests
{
    public class CoursesPageTest : BaseDriver
    {
        CoursesPageModel coursesModel;

        public CoursesPageTest()
        {
            coursesModel = new CoursesPageModel();
        }
        [TestCase("Днепр")]
        [TestCase("Киев")]
        [TestCase("Баку")]
        [TestCase("Санкт-Петербург")]
        [TestCase("Харьков")]

        public void CheckCities(string extRes)
        {
            driver.Url = Urls.coursesPage;
            if (extRes == "Днепр")
            {
                IWebElement mainLabel = driver.FindElement(By.XPath(coursesModel.dniproLableXPath));
                string actRes = mainLabel.Text;
                Assert.AreEqual(extRes, actRes);
            }
            if (extRes == "Киев")
            {
                IWebElement mainLabel = driver.FindElement(By.XPath(coursesModel.kyivLableXPath));
                string actRes = mainLabel.Text;
                Assert.AreEqual(extRes, actRes);
            }
            if (extRes == "Баку")
            {
                IWebElement mainLabel = driver.FindElement(By.XPath(coursesModel.bakuLableXPath));
                string actRes = mainLabel.Text;
                Assert.AreEqual(extRes, actRes);
            }
            if (extRes == "Санкт-Петербург")
            {
                IWebElement mainLabel = driver.FindElement(By.XPath(coursesModel.spbLableXPath));
                string actRes = mainLabel.Text;
                Assert.AreEqual(extRes, actRes);
            }
            if (extRes == "Харьков")
            {
                IWebElement mainLabel = driver.FindElement(By.XPath(coursesModel.kharkivLableXPath));
                string actRes = mainLabel.Text;
                Assert.AreEqual(extRes, actRes);
            }
        }

        [Test]
        public void CheckGoToQaCourse()
        {
            driver.Url = Urls.coursesPage;
            IWebElement qaCourse = driver.FindElement(By.XPath(coursesModel.qaLableXPath));
            qaCourse.Click();


            IWebElement qaTitle = driver.FindElement(By.ClassName(coursesModel.qaTitleClass));
            string actRes = qaTitle.Text;
            Assert.AreEqual("Описание курса", actRes);
            //Thread.Sleep(2000);

        }

        [Test]
        public void CheckShowQaCourse()
        {
            driver.Url = Urls.coursesPage;
            IWebElement qaCourse = driver.FindElement(By.XPath(coursesModel.qaLableXPath));
            qaCourse.Click();


            IWebElement qaTitle = driver.FindElement(By.XPath(coursesModel.jiraXpath));
            qaTitle.Click();

            string actRes = driver.FindElement(By.XPath("/html/body/div[1]/main/section[2]/div/ol/ul[5]/li[1]")).Text;
            Assert.AreEqual("Элементы и примеры работ в JIRA", actRes);
            //Thread.Sleep(20000);
        }

        [Test]
        public void CheckGoToCSharpCourse()
        {
            driver.Url = Urls.coursesPage;
            IWebElement cSharpCourse = driver.FindElement(By.XPath(coursesModel.cSharpLableXPath));
            cSharpCourse.Click();


            IWebElement cSharpTitle = driver.FindElement(By.ClassName(coursesModel.cSharpTitleClass));
            string actRes = cSharpTitle.Text;
            Assert.AreEqual("Описание курса", actRes);
            //Thread.Sleep(2000);

        }


        [Test]
        public void CheckShowCSharpCourses()
        {
            driver.Url = Urls.coursesPage;
            IWebElement cSharpCourse = driver.FindElement(By.XPath(coursesModel.cSharpLableXPath));
            cSharpCourse.Click();

            IWebElement qaTitle = driver.FindElement(By.XPath(coursesModel.week5Xpath));
            qaTitle.Click();
            //Thread.Sleep(2000);
            string actRes = driver.FindElement(By.XPath("/html/body/div[1]/main/section[2]/div/ol/ul[5]/li[1]")).Text;
            Assert.AreEqual("Введение в ООП. Классы и объекты", actRes);
        }
    }
}
