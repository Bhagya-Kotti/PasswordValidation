
using NUnit.Framework;
using System;

namespace PasswordValidation.Services.Test
{
    [TestFixture]
    public class PasswordValidationServiceUnitTest
    {
        //1.Lenght should be 8 charachers
        //2.Atleast 2 numbers
        [Test]
        public void ScenarioWherePasswordIsAtleastEightCharctersLong()
        {
            int actualValue = 10;
            int expectedValue = 8;
            Assert.IsTrue(actualValue >= expectedValue);
        }
    }
}
