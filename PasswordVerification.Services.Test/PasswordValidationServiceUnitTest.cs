
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
        public void ScenarioWherePasswordIsAtleastEightCharctersLong()
        {
            string passWord = "Somepassword";
            int  actualValue = _passwordValidationService.GetLenghOfTheInputPasswordValue(passWord);
            int expectedValue = 8;
            Assert.IsTrue(actualValue >= expectedValue);
        }

        [Test]        
        public void ScenarioWherePasswordAtleastHaveTwoNumerics()
        {
            int actualValue = 1 ;
            int expectedValue = 2;
            Assert.IsTrue(actualValue >= expectedValue);
        }
    }
}
