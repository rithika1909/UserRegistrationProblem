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
    }
}
