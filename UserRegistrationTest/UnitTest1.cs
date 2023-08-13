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
            string input = "rithika.l@gmail.com";
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
            string input = "91 9789286865";
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
            string input = "rithika@123";
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
            string input = "Rithika123";
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
            string input = "Rithika123";
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
            string input = "Rithika@123";
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

        [Test]
        public void TestAllEmails()
        {
            string[] input = { "abc@gmail.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com","abc-100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
            Validate trueEmails = new Validate();
            foreach (var item in input)
            {
                bool result = trueEmails.Email(item);
                Assert.IsTrue(result);
            }
        }

        [Test]
        public void TestFirstNameRegex()
        {
            string input = "Rithika";
            Validate firstName = new Validate();
            bool result = firstName.ValidateFirstNameRegex(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestLastNameRegex()
        {
            string input = "Logachandran";
            Validate lastName = new Validate();
            bool result = lastName.ValidateLastNameRegex(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestEmailRegex()
        {
            string input = "rithika.l@gmail.com";
            Validate email = new Validate();
            bool result = email.ValidateEmailRegex(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestPhoneNumberRegex()
        {
            string input = "91 9789286965";
            Validate phonenumber = new Validate();
            bool result = phonenumber.ValidatePhoneNumberRegex(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestPasswordRegex()
        {
            string input = "Rithika@123";
            Validate password = new Validate();
            bool result = password.ValidatePasswordRegex(input);
            Assert.IsTrue(result);
        }
    }
}