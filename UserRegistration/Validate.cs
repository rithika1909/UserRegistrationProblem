using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Validate
    {

        string firstName = "^[A-Z]{1}[a-z]{2,}$";
        string lastName = "^[A-Z]{1}[a-z]{2,}$";
        string email = "^[a-z]+[._+-]{0,1}[a-z]+[@]{1}[a-z]+[.]{1}[a-z]{2,3}([.]{1}[a-z]{2}){0,1}$";
        string phoneNumber = "^[0-9]{2}[ ]{1}[0-9]{10}$";
        string character = "^.{8,}$";
        string upperCase = "^(?=.*[A-Z]).{8,}$";
        string numeric = "^(?=.*[A-Z])(?=.*[0-9]).{8,}$";
        string specialCharacter = @"^(?=.*[\$\&\+\,\:\;\=\?\@\#\|\'\<\>\.\-\^\*\(\)\%\!])(?=.*[0-9])(?=.*[A-Z]).{8,}$";

        public bool FirstName(string input)
        {
            bool result = Regex.IsMatch(input, firstName);
             return result;
           
        }
        public bool LastName(string input)
        {
            bool result = Regex.IsMatch(input, lastName);
            return result;
        }
        public  bool Email(string input)
        {
            bool result = Regex.IsMatch(input, email);
            return result;
        }
        public bool PhoneNumber(string input)
        {
            bool result = Regex.IsMatch(input, phoneNumber);
            return result;
        }
        public bool CheckCharacter(string input)
        {
            bool result = Regex.IsMatch(input, character);
            return result;
        }

        public bool UpperCase(string input)
        {
            bool result = Regex.IsMatch(input, upperCase);
            return result;
        }
        public bool Numeric(string input)
        {
            bool result = Regex.IsMatch(input, numeric);
            return result;
        }
        public bool SpecialCharacter(string input)
        {
            bool result = Regex.IsMatch(input, specialCharacter);
            return result;
        }
        public bool ValidateRegex(string input) => Regex.IsMatch(input, specialCharacter)? true : false;

    }
}