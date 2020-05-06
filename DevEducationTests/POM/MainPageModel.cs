using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTests.POM
{
    public class MainPageModel
    {
        public By mainLabel = By.TagName("h1");
        public By courseMenuButton = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[1]/a");
        public By graduatesMenuButton = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[2]/a");
        public By newsMenuButton = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[3]/a");
        public By blogMenuButton = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[4]/a");
        public By aboutUsMenuButton = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[5]/a");
        public By contactsMenuButton = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[6]/a");
        public By languageBar = By.ClassName("lang-switcher-header-btn");
        public By signUpButtonLabelClassName = By.ClassName("modal-btn");
        public By FAQButton = By.XPath("/html/body/div[1]/footer/div/nav/ul/li[7]/a");


        IWebElement mainLabelElement;
        IWebElement courseMenuButtonElement;
        IWebElement graduatesMenuButtonElement;
        IWebElement newsMenuButtonElement;
        IWebElement blogMenuButtonElement;
        IWebElement aboutUsMenuButtonElement;
        IWebElement contactsMenuButtonElement;
        IWebElement languageBarElement;
        IWebElement signUpButtonElement;
        IWebElement FAQButtonElement;

        private IWebDriver _driver;

        public MainPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }
        public MainPageModel FindMainLabel()
        {
            mainLabelElement = _driver.FindElement(mainLabel);
            return this;
        }
        public MainPageModel FindCourseMenuButtonLabel()
        {
            courseMenuButtonElement = _driver.FindElement(courseMenuButton);
            return this; 
        }
        public MainPageModel FindNewsMenuButtonLabel()
        {
            newsMenuButtonElement = _driver.FindElement(newsMenuButton);
            return this;
        }

        public MainPageModel FindGraduatesMenuButtonLabel()
        {
            graduatesMenuButtonElement = _driver.FindElement(graduatesMenuButton);
            return this;
        }

        public MainPageModel FindBlogMenuButtonLabel()
        {
            blogMenuButtonElement = _driver.FindElement(blogMenuButton);
            return this; 
        }

        public MainPageModel FindAboutUsMenuButtonLabel()
        {
            aboutUsMenuButtonElement = _driver.FindElement(aboutUsMenuButton);
            return this; 
        }

        public MainPageModel FindContactsMenuButtonLabel()
        {
            contactsMenuButtonElement = _driver.FindElement(contactsMenuButton);
            return this; 
        }

        public MainPageModel FindLanguageBarLabel()
        {
            languageBarElement = _driver.FindElement(languageBar);
            return this; 
        }

        public MainPageModel FindSignUp()
        {
            signUpButtonElement = _driver.FindElement(signUpButtonLabelClassName);
            return this; 
        }

        public MainPageModel FindFAQButton()
        {
            FAQButtonElement = _driver.FindElement(FAQButton);
            return this; 
        }



   
        public string GetTextFromMainLabel()
        {
            return mainLabelElement.Text;
        }

      
        public string GetTextFromCoursesMenuButton()
        {
            return courseMenuButtonElement.Text;
        }

        public string GetTextFromGraduatesMenuButton()
        {
            return graduatesMenuButtonElement.Text;
        }
        public string GetTextFromNewsMenuButton()
        {
            return newsMenuButtonElement.Text;
        }
        public string GetTextFromBlogMenuButton()
        {
            return blogMenuButtonElement.Text;
        }
        public string GetTextFromAboutUsMenuButton()
        {
            return aboutUsMenuButtonElement.Text;
        }
        public string GetTextFromContactsMenuButton()
        {
            return contactsMenuButtonElement.Text;
        }
        public string GetTextFromLanguageBar()
        {
            return languageBarElement.Text;
        }

        //
        public MainPageModel FindCourseMenuButton()
        {
            courseMenuButtonElement = _driver.FindElement(courseMenuButton);
            return this;
        }
        public CoursesPageModel ClickOnCourseButton()
        {
            courseMenuButtonElement.Click();
            return new CoursesPageModel(_driver); 
        }

        public FAQPageModel ClickOnFAQButton()
        {
            FAQButtonElement.Click();
            return new FAQPageModel(_driver);
        }

        public SignUpPageModel ClickOnSignUp()
        {
            signUpButtonElement.Click();
            return new SignUpPageModel(_driver); 
        }


    }
}
