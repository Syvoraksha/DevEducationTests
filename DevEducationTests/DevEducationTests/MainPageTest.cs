using DevEducationTests.POM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTests
{
    public class MainPageTest:BaseDriver
    {
        MainPageModel pageModel;

        public MainPageTest()
        {
            pageModel = new MainPageModel();
        }
        [Test]
        
        public void CheckMainLabel()
        {
            base.driver.Url = Urls.mainPage;
            pageModel.FindMainLabel();
            string actResult =  pageModel.GetMainLabelText();
            Assert.AreEqual("Международный IT-колледж", actResult);
            
        }

    }
}
