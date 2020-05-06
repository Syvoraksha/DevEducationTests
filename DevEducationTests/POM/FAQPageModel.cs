using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTests.POM
{
    public class FAQPageModel
    {
        public By question1 = By.XPath("/html/body/div[1]/main/section/div[2]/div[2]/h2");
        public By answer1 = By.XPath("/html/body/div[1]/main/section/div[2]/div[2]/div/p");
        public string answer1Text = "По окончании курса вы получите сертификат, подтверждающий вашу квалификацию.";

        private IWebDriver _driver;
        public FAQPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }
        IWebElement question1Element;
        IWebElement answer1Element;

        public FAQPageModel FindQuestion1()
        {
            question1Element = _driver.FindElement(question1);
            return this; 
        }

        public FAQPageModel FindAnswer1()
        {
            answer1Element = _driver.FindElement(answer1);
            return this; 
        }

        public FAQPageModel ClickOnQuestion1()
        {

            question1Element.Click();
            //System.Threading.Thread.Sleep(5000);
            return this;
        }

        public string GetTextFromAnswer1()
        {
            return answer1Element.Text;
        }

        public string GetExpResultAnswer1()
        {
            return answer1Text;
        }


    }
}
