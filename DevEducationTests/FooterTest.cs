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
    public class FooterTest : BaseDriver
    {
        SocialNetworkLinks socialNetworkLinks;

        [Test]
        public void CheckFbLink()
        {
            socialNetworkLinks = new SocialNetworkLinks(driver);
            driver.Url = Urls.mainPage;
            string actRes = socialNetworkLinks.GetFbLink();
   
            string expRes = socialNetworkLinks.fbLink;
            Assert.AreEqual(expRes, actRes);
            Thread.Sleep(2000);
        }

        [Test]
        public void CheckInstaLink()
        {
            socialNetworkLinks = new SocialNetworkLinks(driver);
            driver.Url = Urls.mainPage;
            string actRes = socialNetworkLinks.GetInstaLink();

            string expRes = socialNetworkLinks.instaLink;
            Assert.AreEqual(expRes, actRes);
            Thread.Sleep(2000);
        }

        [Test]
        public void CheckYouTubeLink()
        {
            socialNetworkLinks = new SocialNetworkLinks(driver);
            driver.Url = Urls.mainPage;
            string actRes = socialNetworkLinks.GetYouTubeLink();

            string expRes = socialNetworkLinks.youTubeLink;
            Assert.AreEqual(expRes, actRes);
            Thread.Sleep(2000);
        }
    }
}
