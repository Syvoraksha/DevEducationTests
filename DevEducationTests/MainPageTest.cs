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
    public class MainPageTest : BaseDriver
    {
        MainPageModel pageModel;
        CoursesPageModel coursesModel;
        GraduatesPageModel graduatesModel;
        NewsPageModel newsModel;
        BlogPageModel blogModel;
        AboutUsPageModel aboutUsModel;
        ContactsPageModel contactsModel;
        SignUpPageModel signUpPageModel;
        


        public MainPageTest()
        {
            pageModel = new MainPageModel();
            coursesModel = new CoursesPageModel();
            graduatesModel = new GraduatesPageModel();
            newsModel = new NewsPageModel();
            blogModel = new BlogPageModel();
            aboutUsModel = new AboutUsPageModel();
            contactsModel = new ContactsPageModel();
            signUpPageModel = new SignUpPageModel();
        }

        [TestCase("Курсы")]
        [TestCase("Выпускники")]
        [TestCase("Новости")]
        [TestCase("Блог")]
        [TestCase("О нас")]
        [TestCase("Контакты")]

        public void CheckCourseMenuButton(string expRes)
        {
            driver.Url = Urls.mainPage;
            if (expRes == "Курсы")
            {
                IWebElement mainLabel = driver.FindElement(By.XPath(pageModel.courseMenuButtonXPath));
                string actResult = mainLabel.Text;
                Assert.AreEqual(expRes, actResult);
            }
            if (expRes == "Выпускники")
            {
                IWebElement mainLabel = driver.FindElement(By.XPath(pageModel.graduatesMenuButtonXPath));
                string actResult = mainLabel.Text;
                Assert.AreEqual(expRes, actResult);
            }
            if (expRes == "Новости")
            {
                IWebElement mainLabel = driver.FindElement(By.XPath(pageModel.newsMenuButtonXPath));
                string actResult = mainLabel.Text;
                Assert.AreEqual(expRes, actResult);
            }

            if (expRes == "Блог")
            {
                IWebElement mainLabel = driver.FindElement(By.XPath(pageModel.blogMenuButtonXPath));
                string actResult = mainLabel.Text;
                Assert.AreEqual(expRes, actResult);
            }

            if (expRes == "О нас")
            {
                IWebElement mainLabel = driver.FindElement(By.XPath(pageModel.aboutUsMenuButtonXPath));
                string actResult = mainLabel.Text;
                Assert.AreEqual(expRes, actResult);
            }

            if (expRes == "Контакты")
            {
                IWebElement mainLabel = driver.FindElement(By.XPath(pageModel.contactsMenuButtonXPath));
                string actResult = mainLabel.Text;
                Assert.AreEqual(expRes, actResult);
            }

        }


        [Test]
        public void CheckGoToCourses()
        {
            driver.Url = Urls.mainPage;
            IWebElement coursesButton = driver.FindElement(By.XPath(pageModel.courseMenuButtonXPath));
            coursesButton.Click();
            Thread.Sleep(2000);
            IWebElement ourCoursesLabel = driver.FindElement(By.TagName(coursesModel.ourCoursesLabelTagName));
            string actResult = ourCoursesLabel.Text;
            Assert.AreEqual("Наши курсы", actResult);
        }
        [Test]

        public void CheckGoToGraduatess()
        {
            driver.Url = Urls.mainPage;
            IWebElement graduatessButton = driver.FindElement(By.XPath(pageModel.graduatesMenuButtonXPath));
            graduatessButton.Click();
            Thread.Sleep(2000);
            IWebElement ourCoursesLabel = driver.FindElement(By.TagName(graduatesModel.graduatessLabelTagName));
            string actResult = ourCoursesLabel.Text;
            Assert.AreEqual("Наши выпускники", actResult);
        }

        [Test]
        public void CheckGoToNews()
        {
            driver.Url = Urls.mainPage;
            IWebElement newsButton = driver.FindElement(By.XPath(pageModel.newsMenuButtonXPath));
            newsButton.Click();
            Thread.Sleep(5000);
            IWebElement newsLabel = driver.FindElement(By.TagName(newsModel.newsCoursesLabelTagName));
            string actResult = newsLabel.Text;
            Assert.AreEqual("Новости", actResult);
        }


        [Test]
        public void CheckGoToBlog()
        {
            driver.Url = Urls.mainPage;
            IWebElement blogMButton = driver.FindElement(By.XPath(pageModel.blogMenuButtonXPath));
            blogMButton.Click();
            Thread.Sleep(5000);
            IWebElement blogMLabel = driver.FindElement(By.TagName(blogModel.blogLabelTagName));
            string actResult = blogMLabel.Text;
            Assert.AreEqual("Блог", actResult);
        }

        [Test]
        public void CheckGoToAboutUs()
        {
            driver.Url = Urls.mainPage;
            IWebElement aboutUsMButton = driver.FindElement(By.XPath(pageModel.aboutUsMenuButtonXPath));
            aboutUsMButton.Click();
            Thread.Sleep(5000);
            IWebElement aboutUsMLabel = driver.FindElement(By.TagName(aboutUsModel.aboutUsLabelTagName));
            string actResult = aboutUsMLabel.Text;
            Assert.AreEqual("О нас", actResult);
        }

        [Test]
        public void CheckGoToContacts()
        {
            driver.Url = Urls.mainPage;
            IWebElement contactsUsMButton = driver.FindElement(By.XPath(pageModel.contactsMenuButtonXPath));
            contactsUsMButton.Click();
            Thread.Sleep(5000);
            IWebElement contactsMLabel = driver.FindElement(By.TagName(contactsModel.contactsLabelTagName));
            string actResult = contactsMLabel.Text;
            Assert.AreEqual("Наши контакты", actResult);
        }
        [TestCase("RU")]
        [TestCase("UA")]
        [TestCase("EN")]
        [TestCase("AZ")]


        public void Checklanguage(string expRes)
        {
            if (expRes == "RU")
            {
                driver.Url = Urls.mainPage;
                IWebElement contactsUsMButton = driver.FindElement(By.ClassName("lang-switcher-header-btn"));
                Thread.Sleep(5000);
                string actResult = contactsUsMButton.Text;
                Assert.AreEqual("RU", actResult);
            }
            if (expRes == "UA")
            {
                driver.Url = Urls.mainPageUA;
                IWebElement contactsUsMButton = driver.FindElement(By.ClassName("lang-switcher-header-btn"));
                Thread.Sleep(5000);
                string actResult = contactsUsMButton.Text;
                Assert.AreEqual("UA", actResult);
            }
            if (expRes == "EN")
            {
                driver.Url = Urls.mainPageEN;
                IWebElement contactsUsMButton = driver.FindElement(By.ClassName("lang-switcher-header-btn"));
                Thread.Sleep(5000);
                string actResult = contactsUsMButton.Text;
                Assert.AreEqual("EN", actResult);
            }
            if (expRes == "AZ")
            {
                driver.Url = Urls.mainPageAZ;
                IWebElement contactsUsMButton = driver.FindElement(By.ClassName("lang-switcher-header-btn"));
                Thread.Sleep(5000);
                string actResult = contactsUsMButton.Text;
                Assert.AreEqual("AZ", actResult);
            }
        }

        [Test]
        public void CheckSignUpForCourseQA()
        {

            driver.Url = Urls.mainPage;
            IWebElement signUpForCourseButton = driver.FindElement(By.ClassName(signUpPageModel.сourseButtonLabelClassName));
            signUpForCourseButton.Click();
            Thread.Sleep(5000);

            IWebElement inputFIO = driver.FindElement(By.Name(signUpPageModel.inputFIOLabelName));
            inputFIO.SendKeys("Владимир");


            IWebElement inputTel = driver.FindElement(By.Name(signUpPageModel.inputTelLabelName));
            inputTel.SendKeys("+380951444363");


            IWebElement inputMail = driver.FindElement(By.Name(signUpPageModel.inputMailLabelName));
            inputMail.SendKeys("syvorakshav@gmail.com");


            IWebElement selectCity = driver.FindElement(By.Id("city-popup"));
            selectCity.Click();
            selectCity.FindElement(By.XPath("/html/body/div[1]/main/div[2]/div/div/form/div[4]/select/option[4]")).Click();

            IWebElement selectCorse = driver.FindElement(By.Id("course-popup"));
            selectCorse.Click();
            selectCorse.FindElement(By.XPath("/html/body/div[1]/main/div[2]/div/div/form/div[5]/select/option[7]")).Click();

        }

        [Test]

        public void CheckSignUpForCourseCSharp()
        {

            driver.Url = Urls.mainPage;
            IWebElement signUpForCourseButton = driver.FindElement(By.ClassName(signUpPageModel.сourseButtonLabelClassName));
            signUpForCourseButton.Click();
            Thread.Sleep(5000);

            IWebElement inputFIO = driver.FindElement(By.Name(signUpPageModel.inputFIOLabelName));
            inputFIO.SendKeys("Владимир");


            IWebElement inputTel = driver.FindElement(By.Name(signUpPageModel.inputTelLabelName));
            inputTel.SendKeys("+380951444363");


            IWebElement inputMail = driver.FindElement(By.Name(signUpPageModel.inputMailLabelName));
            inputMail.SendKeys("syvorakshav@gmail.com");


            IWebElement selectCity = driver.FindElement(By.Id("city-popup"));
            selectCity.Click();
            selectCity.FindElement(By.XPath("/html/body/div[1]/main/div[2]/div/div/form/div[4]/select/option[3]")).Click();

            IWebElement selectCorse = driver.FindElement(By.Id("course-popup"));
            selectCorse.Click();
            selectCorse.FindElement(By.XPath("/html/body/div[1]/main/div[2]/div/div/form/div[5]/select/option[3]")).Click();

        }
    }
}
