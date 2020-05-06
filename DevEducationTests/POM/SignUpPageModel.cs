using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevEducationTests.POM
{
    public class SignUpPageModel
    {
      
        public By inputFIOLabelName = By.Name("entry.317589276");
        public By inputTelLabelName = By.Name("entry.870452131");
        public By inputMailLabelName = By.Name("entry.1133896419");

        private IWebDriver _driver;

        IWebElement inputFIOElement;
        IWebElement inputTelElement;
        IWebElement inputMailElement;

        public SignUpPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }

        public SignUpPageModel FindInputFIO()
        {
            inputFIOElement = _driver.FindElement(inputFIOLabelName);
            return this;
        }
        public SignUpPageModel FindInputTel()
        {
            inputTelElement = _driver.FindElement(inputTelLabelName);
            return this;
        }
        public SignUpPageModel FindInputMail()
        {
            inputMailElement = _driver.FindElement(inputMailLabelName);
            return this;
        }

        public SignUpPageModel InputFIO()
        {
            inputFIOElement.SendKeys("Владимир");
            return this;
        }
        public SignUpPageModel InputTel()
        {
            inputTelElement.SendKeys("+380951444363");
            return this;
        }
        public SignUpPageModel InputMail()
        {
            inputMailElement.SendKeys("syvoakshav@gmail.com");
            return this;
        }

        public SignUpPageModel SelectCityKiev()
        {
            IWebElement selectCity = _driver.FindElement(By.Id("city-popup"));
            
            selectCity.Click();
            selectCity.FindElement(By.XPath("/html/body/div[1]/main/div[2]/div/div/form/div[4]/select/option[4]")).Click();
            return this;
        }
        public SignUpPageModel SelectCitySPB()
        {
            IWebElement selectCity = _driver.FindElement(By.Id("city-popup"));

            selectCity.Click();
            selectCity.FindElement(By.XPath("/html/body/div[1]/main/div[2]/div/div/form/div[4]/select/option[5]")).Click();
            return this;
        }
        public SignUpPageModel SelectCityBaku()
        {
            IWebElement selectCity = _driver.FindElement(By.Id("city-popup"));

            selectCity.Click();
            selectCity.FindElement(By.XPath("/html/body/div[1]/main/div[2]/div/div/form/div[4]/select/option[6]")).Click();
            return this;
        }

        public SignUpPageModel SelectCourseQA()
        {
            IWebElement selectCorse = _driver.FindElement(By.Id("course-popup"));
            selectCorse.Click();
            selectCorse.FindElement(By.XPath("/html/body/div[1]/main/div[2]/div/div/form/div[5]/select/option[7]")).Click();
            return this;
        }

        public SignUpPageModel SelectCourseCShparp()
        {
            IWebElement selectCorse = _driver.FindElement(By.Id("course-popup"));
            selectCorse.Click();
            selectCorse.FindElement(By.XPath("/html/body/div[1]/main/div[2]/div/div/form/div[5]/select/option[3]")).Click();
            return this;
        }

        


    }
}
