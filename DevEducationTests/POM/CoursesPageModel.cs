using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTests.POM
{
    public class CoursesPageModel
    {
        public By ourCoursesLabel = By.TagName("h1");
        IWebElement coursesLabel;
        private IWebDriver _driver;
        public CoursesPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }

        public CoursesPageModel FindCoursesLabel()
        {
            coursesLabel = _driver.FindElement(ourCoursesLabel);
            return this;
        }

        public string GetTextFromCoursesLabel()
        {
            return coursesLabel.Text;
        }
    }
}
