using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTests.POM
{
    public class ContactsPageModel
    {
        private IWebDriver _driver;
        public ContactsPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }

        public By contactsLabelTagName = By.TagName("h1");

        public string kyivAdress = "ст. метро Васильковская, ул. Сумская,1";
        public By kyivButtonXPath = By.XPath("/html/body/div[1]/main/section[1]/div/div[1]/button[2]");
        public By kyivAdressXPath = By.XPath("/html/body/div[1]/main/section[1]/div/div[2]/div[2]/div[1]/div[2]/div[1]");

        public string dniproAdress = "ул.Симферопольская, 17";
        public By dniproButtonXPath = By.XPath("/html/body/div[1]/main/section[1]/div/div[1]/button[1]");
        public By dniproAdressXPath = By.XPath("/html/body/div[1]/main/section[1]/div/div[2]/div[1]/div[1]/div[2]/div[1]");

        public string bakuAdress = "проспект Бабека 10E, Rusel Plaza, 7 этаж";
        public By bakuButtonXPath = By.XPath("/html/body/div[1]/main/section[1]/div/div[1]/button[3]");
        public By bakuAdressXPath = By.XPath("/html/body/div[1]/main/section[1]/div/div[2]/div[3]/div[1]/div[2]/div[1]");

        public By askQuestionButtonXPath = By.XPath("/html/body/div[1]/main/section[2]/div/button");
        public By inputName = By.Name("name");
        public By inputEmail = By.XPath("/html/body/div[1]/main/div[3]/div/div/form/div[2]/input");
        public By inputMessage = By.Name("message");

        IWebElement kyivButtonElement;
        IWebElement kyivAdressElement;
        IWebElement dniproButtonElement;
        IWebElement dniproAdressElement;
        IWebElement bakuButtonElement;
        IWebElement bakuAdressElement;
        IWebElement askQuestionButtonElement;
        IWebElement inputNameElement;
        IWebElement inputEmailElement;
        IWebElement inputMessageElement;

        public ContactsPageModel FindKyivButton()
        {
            kyivButtonElement = _driver.FindElement(kyivButtonXPath);
            return this; 
        }
        public ContactsPageModel FindBakuButton()
        {
            bakuButtonElement = _driver.FindElement(bakuButtonXPath);
            return this;
        }

        public ContactsPageModel FindKyivLabel()
        {
            kyivAdressElement = _driver.FindElement(kyivAdressXPath);
            return this;
        }
        public ContactsPageModel FindDniproLabel()
        {
            dniproAdressElement = _driver.FindElement(dniproAdressXPath);
            return this;
        }

        public ContactsPageModel FindBakuLabel()
        {
            bakuAdressElement = _driver.FindElement(bakuAdressXPath);
            return this;
        }

        public ContactsPageModel FindDniproButton()
        {
            dniproButtonElement = _driver.FindElement(dniproButtonXPath);
            return this;
        }

        public ContactsPageModel FindAskQuestionButton()
        {
            askQuestionButtonElement = _driver.FindElement(askQuestionButtonXPath);
            return this;
        }

        public ContactsPageModel FindInputNameField()
        {
            inputNameElement = _driver.FindElement(inputName);
            return this;
        }

        public ContactsPageModel FindInputEmailField()
        {
            inputEmailElement = _driver.FindElement(inputEmail);
            return this;
        }

        public ContactsPageModel FindInputMessageField()
        {
            inputMessageElement = _driver.FindElement(inputMessage);
            return this;
        }

        public ContactsPageModel ClickKyivButton()
        {
            kyivButtonElement.Click();
            return this;
        }
        public ContactsPageModel ClickDniproButton()
        {
            dniproButtonElement.Click();
            return this;
        }
        public ContactsPageModel ClickBakuButton()
        {
            bakuButtonElement.Click();
            return this;
        }
        public ContactsPageModel ClickAskQuestioonButton()
        {
            askQuestionButtonElement.Click();
            return this;
        }

        public ContactsPageModel InputNameInField()
        {
            inputNameElement.SendKeys("Petrovich");
            return this;
        }

        public ContactsPageModel InputEmailInField()
        {
            inputEmailElement.SendKeys("petrovich@gmail.com");
            return this;
        }

        public ContactsPageModel InputMessageInField()
        {
            inputMessageElement.SendKeys("How are you?");
            return this;
        }

        public string GetTextFromKyivAdressLabel()
        {
            return kyivAdressElement.Text;
        }
        public string GetTextFromDniproAdressLabel()
        {
            return dniproAdressElement.Text;
        }

        public string GetTextFromBakuAdressLabel()
        {
            return bakuAdressElement.Text;
        }

    }
}
