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
    public class FooterTest: BaseDriver
    {
        SocialNetworkLinks socialNetworkLinks;
        public FooterTest()
        {
            socialNetworkLinks = new SocialNetworkLinks();
        }

        [Test]
        public void CheckFbLink()
        {
            driver.Url = Urls.coursesPage;
            IWebElement fbBotton = driver.FindElement(By.XPath(socialNetworkLinks.fbButtonXPath));
            string actRes = fbBotton.GetAttribute("href");

            string expRes = socialNetworkLinks.fbLink;
            Assert.AreEqual(expRes, actRes);
            //Thread.Sleep(2000);

        }
        [Test]
        public void CheckInstaLink()
        {
            driver.Url = Urls.coursesPage;
            IWebElement instaBotton = driver.FindElement(By.XPath(socialNetworkLinks.instaButtonXPath));
            string actRes = instaBotton.GetAttribute("href");

            string expRes = socialNetworkLinks.instaLink;
            Assert.AreEqual(expRes, actRes);
            //Thread.Sleep(2000);

        }


        [Test]
        public void CheckYouTubeLink()
        {
            driver.Url = Urls.coursesPage;
            IWebElement youTubeBotton = driver.FindElement(By.XPath(socialNetworkLinks.youTubeButtonXPath));
            string actRes = youTubeBotton.GetAttribute("href");

            string expRes = socialNetworkLinks.youTubeLink;
            Assert.AreEqual(expRes, actRes);
            //Thread.Sleep(2000);

        }
    }
}
