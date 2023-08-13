using System.ComponentModel.DataAnnotations;
using UserRegistration;

namespace UserRegistrationTest
{
    public class Tests
    {

        [Test]
        public void TestFirstName()
        {
            string input = "Rithikaa";
            Validate firstName = new Validate();
            bool result = firstName.FirstName(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
        [Test]
        public void TestLastName()
        {
            string input = "Logachandran";
            Validate lastName = new Validate();
            bool result = lastName.LastName(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
        [Test]
        public void TestEmail()
        {
            string input = "rithika.l1909@gmail.com";
            Validate email = new Validate();
            bool result = email.Email(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
        [Test]
        public void TestPhoneNumber()
        {
            string input = "9789286965";
            Validate phonenumber = new Validate();
            bool result = phonenumber.PhoneNumber(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
        [Test]
        public void TestCheckCharacter()
        {
            string input = "rithika@1234";
            Validate character = new Validate();
            bool result = character.CheckCharacter(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
        [Test]
        public void TestUpperCase()
        {
            string input = "Rithika1234";
            Validate uppercase = new Validate();
            bool result = uppercase.UpperCase(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
        [Test]
        public void TestNumeric()
        {
            string input = "Rithika1234";
            Validate numeric = new Validate();
            bool result = numeric.Numeric(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
        [Test]
        public void TestSpecialCharacter()
        {
            string input = "Rithika@1234";
            Validate special = new Validate();
            bool result = special.SpecialCharacter(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
    }
}
