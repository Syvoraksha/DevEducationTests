using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTests.POM
{
    public class SocialNetworkLinks
    {
        public string fbLink = "https://www.facebook.com/IT.DevEducation/";
        public By fbButtonXPath = By.XPath("/html/body/div[1]/footer/div/ul/li[2]/a");

        public string instaLink = "https://instagram.com/dev.education";
        public By instaButtonXPath = By.XPath("/html/body/div[1]/footer/div/ul/li[3]/a");

        public string youTubeLink = "https://instagram.com/dev.education";
        public By youTubeButtonXPath = By.XPath("/html/body/div[1]/footer/div/ul/li[3]/a");

        private IWebDriver _driver;

        public SocialNetworkLinks(IWebDriver driver)
        {
            this._driver = driver;
        }

        public string GetFbLink()
        {
            IWebElement fbBotton = _driver.FindElement(fbButtonXPath);
            return fbBotton.GetAttribute("href");
        }

        public string GetInstaLink()
        {
            IWebElement instaBotton = _driver.FindElement(instaButtonXPath);
            return instaBotton.GetAttribute("href");
        }

        public string GetYouTubeLink()
        {
            IWebElement youTubeBotton = _driver.FindElement(youTubeButtonXPath);
            return youTubeBotton.GetAttribute("href");
        }

    }
}
