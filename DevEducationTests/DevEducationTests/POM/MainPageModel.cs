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
        IWebElement mainLabel;
        IWebElement courseMenuButton;
        IWebElement graduateMenuButton;
        IWebElement newsMenuButton;        IWebElement blogMenuButton;        IWebElement aboutUsMenuButton;        IWebElement contactsMenuButton;        IWebElement selectLanguageButton;


        public void FindMainLabel()
        {
            mainLabel = driver.FindElement(By.ClassName("title"));
        }

        public string GetMainLabelText()
        {
            return mainLabel.Text;
        }




    }
}
