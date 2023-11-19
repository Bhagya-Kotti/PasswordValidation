
using NUnit.Framework;
using PasswordValidation.Service;
using System;

namespace PasswordValidation.Services.Test
{
    [TestFixture]
    public class PasswordValidationServiceUnitTest
    {
        PasswordValidationService _passwordValidationService = new PasswordValidationService();
        //1.Lenght should be 8 charachers
        //2.Atleast 2 numbers

        [Test]
        public void ScenarioTrueWherePasswordIsAtleastEightCharctersLong()
        {
            string passWord = "Somepassword";
            int  actualValue = _passwordValidationService.GetLenghOfTheInputPasswordValue(passWord);
            int expectedValue = 8;
            Assert.IsTrue(actualValue >= expectedValue);
        }
        [Test]
        public void ScenarioFalseWherePasswordIsAtleastEightCharctersLong()
        {
            string passWord = "System";
            int actualValue = _passwordValidationService.GetLenghOfTheInputPasswordValue(passWord);
            int expectedValue = 8;
            Assert.IsFalse(actualValue >= expectedValue);
        }

        [Test]
        public void ScenarioFalseWherePasswordAtleastHaveTwoNumerics()
        {
            string passWord = "somepassword";
            int actualValue = _passwordValidationService.GetNumberOfNumericsInInputPasswordValue(passWord);
            int expectedValue = 2;
            Assert.IsFalse(actualValue >= expectedValue);
        }
        [Test]
        public void ScenarioTrueWherePasswordAtleastHaveTwoNumerics()
        {
            string passWord = "somepassword12";
            int actualValue = _passwordValidationService.GetNumberOfNumericsInInputPasswordValue(passWord);
            int expectedValue = 2;
            Assert.IsTrue(actualValue >= expectedValue);
        }

        [Test]        
        public void ScenarioForCheckingAValidPassword()
        {
            string passWord = "somepassword";
            string actualValue = _passwordValidationService.CheckForValidPassword(passWord);
            string expectedValue = "Password must be at least 8 characters.The password must contain at least 2 numbers.";            
            Assert.That(actualValue, Is.EqualTo(expectedValue));
        }
    }
}
