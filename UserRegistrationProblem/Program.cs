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
                        flag = false;
                        break;
                }

            }



        }
    }
}