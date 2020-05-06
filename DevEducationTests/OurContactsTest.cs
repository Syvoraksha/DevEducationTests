using DevEducationTests.POM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevEducationTests
{
    public class OurContactsTest: BaseDriver
    {
        ContactsPageModel contactsPageModel;

        [Test]
        public void CheckKyivAdress()
        {
            contactsPageModel = new ContactsPageModel(driver);
            driver.Url = Urls.contactPage;
            string actResult = contactsPageModel
            .FindKyivButton()
            .ClickKyivButton()
            .FindKyivLabel()
            .GetTextFromKyivAdressLabel();

            Assert.AreEqual(contactsPageModel.kyivAdress, actResult);
        }

        [Test]
        public void CheckDniproAdress()
        {
            contactsPageModel = new ContactsPageModel(driver);
            driver.Url = Urls.contactPage;
            string actResult = contactsPageModel
            .FindDniproButton()
            .ClickDniproButton()
            .FindDniproLabel()
            .GetTextFromDniproAdressLabel();

            Assert.AreEqual(contactsPageModel.dniproAdress, actResult);
        }

        [Test]
        public void CheckBakuAdress()
        {
            contactsPageModel = new ContactsPageModel(driver);
            driver.Url = Urls.contactPage;
            string actResult = contactsPageModel
            .FindBakuButton()
            .ClickBakuButton()
            .FindBakuLabel()
            .GetTextFromBakuAdressLabel();

            Assert.AreEqual(contactsPageModel.bakuAdress, actResult);
        }

        [Test]
        public void CheckAskQuestion()
        {
            contactsPageModel = new ContactsPageModel(driver);
            driver.Url = Urls.contactPage;
            contactsPageModel
            .FindAskQuestionButton()
            .ClickAskQuestioonButton()
            .FindInputNameField()
            .InputNameInField()
            .FindInputEmailField()
            .InputEmailInField()
            .FindInputMessageField()
            .InputMessageInField();

            Assert.AreEqual(true, true);
        }
    }
}
