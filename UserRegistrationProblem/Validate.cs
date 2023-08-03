using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class Validate
    {
        string firstName = "^[A-Z]{1}[a-z]{2,}$";
        string lastName = "^[A-Z]{1}[a-z]{2,}$";
        string email = "^[a-z]+[._+-]{0,1}[a-z]+[@]{1}[a-z]+[.]{1}[a-z]{2,3}([.]{1}[a-z]{2}){0,1}$";
        string phoneNumber = "^[0-9]{2}[ ]{1}[0-9]{10}$";
        string character = "^.{8,}$";
        public void FirstName(string input)
        {
            bool result = Regex.IsMatch(input, firstName);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation Unsuccessful");
        }
        public void LastName(string input)
        {
            bool result = Regex.IsMatch(input, lastName);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation Unsuccessful");
        }
        public void Email(string input)
        {
            bool result = Regex.IsMatch(input, email);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation Unsuccessful");
        }
        public void PhoneNumber(string input)
        {
            bool result = Regex.IsMatch(input, phoneNumber);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation Unsuccessful");
        }
        public void CheckCharacter(string input)
        {
            bool result = Regex.IsMatch(input, character);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation Unsuccessful");
        }
    }
}
   
