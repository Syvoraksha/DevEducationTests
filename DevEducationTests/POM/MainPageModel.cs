using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTests.POM
{
    public class MainPageModel :BaseDriver
    {
        public string mainLabelTagName = "h1";
        public string courseMenuButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[1]/a";
        public string graduatesMenuButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[2]/a";
        public string newsMenuButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[3]/a";
        public string blogMenuButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[4]/a";
        public string aboutUsMenuButtonXPath  = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[5]/a"; 
        public string contactsMenuButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[6]/a";
        public string selectLanguageButtonXPath = "lang-switcher-header__item active";

    }
}
