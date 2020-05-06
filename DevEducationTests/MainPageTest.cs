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


        [Test]
        public void CheckCourses()
        { 
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

            string actRes = pageModel
            .FindCourseMenuButton()
            .ClickOnCourseButton()
            .FindCoursesLabel()
            .GetTextFromCoursesLabel();
            Assert.AreEqual("Наши курсы", actRes);
        }
        [Test]
        public void CheckCourseMenuButton()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

            string actRes = pageModel
            .FindCourseMenuButtonLabel()
            .GetTextFromCoursesMenuButton();
            Assert.AreEqual("Курсы", actRes);
        }

        [Test]
        public void CheckGraduatesMenuButton()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

            string actRes = pageModel
            .FindGraduatesMenuButtonLabel()
            .GetTextFromGraduatesMenuButton();
            Assert.AreEqual("Выпускники", actRes);
        }

        [Test]
        public void CheckNewsMenuButton()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

            string actRes = pageModel
            .FindNewsMenuButtonLabel()
            .GetTextFromNewsMenuButton();
            Assert.AreEqual("Новости", actRes);
        }

        [Test]
        public void CheckBlogMenuButton()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

            string actRes = pageModel
            .FindBlogMenuButtonLabel()
            .GetTextFromBlogMenuButton();
            Assert.AreEqual("Блог", actRes);
        }

        [Test]
        public void CheckAboutUsMenuButton()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

            string actRes = pageModel
            .FindAboutUsMenuButtonLabel()
            .GetTextFromAboutUsMenuButton();
            Assert.AreEqual("О нас", actRes);
        }

        [Test]
        public void CheckContactsMenuButton()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

            string actRes = pageModel
            .FindContactsMenuButtonLabel()
            .GetTextFromContactsMenuButton();
            Assert.AreEqual("Контакты", actRes);
        }

        [TestCase("RU")]
        [TestCase("UA")]
        [TestCase("EN")]
        [TestCase("AZ")]
        public void Checklanguage(string expRes)
        {
            pageModel = new MainPageModel(driver);

            if (expRes == "RU")
            {
                driver.Url = Urls.mainPage;
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

                string actRes = pageModel
                .FindLanguageBarLabel()
                .GetTextFromLanguageBar();
                Assert.AreEqual("RU", actRes);
            }
            if (expRes == "UA")
            {
                driver.Url = Urls.mainPageUA;
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

                string actRes = pageModel
                .FindLanguageBarLabel()
                .GetTextFromLanguageBar();
                Assert.AreEqual("UA", actRes);
            }
            if (expRes == "EN")
            {
                driver.Url = Urls.mainPageEN;
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

                string actRes = pageModel
                .FindLanguageBarLabel()
                .GetTextFromLanguageBar();
                Assert.AreEqual("EN", actRes);
            }
            if (expRes == "AZ")
            {
                driver.Url = Urls.mainPageAZ;
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

                string actRes = pageModel
                .FindLanguageBarLabel()
                .GetTextFromLanguageBar();
                Assert.AreEqual("AZ", actRes);
            }
        }

        [Test]
        public void CheckSignUpForCourseQAKiev()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
           
            pageModel.FindSignUp()
            .ClickOnSignUp()
            .FindInputTel()
            .FindInputFIO()
            .FindInputMail()
            .InputFIO()
            .InputTel()
            .InputMail()
            .SelectCityKiev()
            .SelectCourseQA();
            

        }

        [Test]
        public void CheckSignUpForCourseCSparpSPB()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            
            pageModel.FindSignUp()
            .ClickOnSignUp()
            .FindInputTel()
            .FindInputFIO()
            .FindInputMail()
            .InputFIO()
            .InputTel()
            .InputMail()
            .SelectCitySPB()
            .SelectCourseCShparp();
      

        }

        [Test]
        public void CheckSignUpForCourseCSparpBaku()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;

            pageModel.FindSignUp()
            .ClickOnSignUp()
            .FindInputTel()
            .FindInputFIO()
            .FindInputMail()
            .InputFIO()
            .InputTel()
            .InputMail()
            .SelectCityBaku()
            .SelectCourseCShparp();
        }

        [Test]
        public void CheckOpenQuestion1FAQ()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;

            string actResult = pageModel.FindFAQButton()
                .ClickOnFAQButton()
                .FindQuestion1()
                .ClickOnQuestion1()
                .FindAnswer1()
                .GetTextFromAnswer1();
            string expRes = new FAQPageModel(driver).answer1Text;
            Assert.AreEqual(expRes, actResult);
        }



    }
}
