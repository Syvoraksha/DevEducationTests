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
        //public string ourCoursesLabelTagName = "h1";
        public By ourCoursesLabel = By.TagName("h1");
        IWebElement coursesLabel;
        //чтобы не передавать драйвер в каждый метод, делаем его в модели
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
