using System.ComponentModel.DataAnnotations;
using UserRegistration;

namespace UserRegistrationTest
{
    public class Tests
    {

        [Test]
        public void TestFirstName()
        {
            string input = "Rithika";
            Validate firstName = new Validate();
            bool result = firstName.FirstName(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestLastName()
        {
            string input = "Logachandran";
            Validate lastName = new Validate();
            bool result = lastName.LastName(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestEmail()
        {
            string input = "rithika.l1909@gmail.com";
            Validate email = new Validate();
            bool result = email.Email(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestPhoneNumber()
        {
            string input = "9789286965";
            Validate phonenumber = new Validate();
            bool result = phonenumber.PhoneNumber(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestCheckCharacter()
        {
            string input = "rithika@123";
            Validate character = new Validate();
            bool result = character.CheckCharacter(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestUpperCase()
        {
            string input = "Rithika123";
            Validate uppercase = new Validate();
            bool result = uppercase.UpperCase(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestNumeric()
        {
            string input = "Rithika123";
            Validate numeric = new Validate();
            bool result = numeric.Numeric(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestSpecialCharacter()
        {
            string input = "Rithika@123";
            Validate special = new Validate();
            bool result = special.SpecialCharacter(input);
            Assert.IsTrue(result);
        }
    }
}
