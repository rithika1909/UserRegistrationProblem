using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Validate validate = new Validate();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the option to execute\n 1.Validate First Name\n " +
                    "2.Validate Last Name\n 3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the first name to validate:");
                        string FirstName = Console.ReadLine();
                        validate.FirstName(FirstName);
                        break;
                    case 2:
                        Console.WriteLine("Enter the last name to validate:");
                        string LastName = Console.ReadLine();
                        validate.LastName(LastName);
                        break;
                    case 3:
                        Console.WriteLine("Enter the email to validate:");
                        string Email = Console.ReadLine();
                        validate.Email(Email);
                        break;
                    case 4:
                        Console.WriteLine("Enter the phone number to validate:");
                        string PhoneNumber = Console.ReadLine();
                        validate.PhoneNumber(PhoneNumber);
                        break;
                    case 5:
                        Console.WriteLine("Enter the password to validate:");
                        string Character = Console.ReadLine();
                        validate.CheckCharacter(Character);
                        break;
                    case 6:
                        Console.WriteLine("Enter the password to validate:");
                        string UpperCase = Console.ReadLine();
                        validate.UpperCase(UpperCase);
                        break;
                    case 7:
                        flag = false;
                        break;
                    
                }

            }



        }
    }
}