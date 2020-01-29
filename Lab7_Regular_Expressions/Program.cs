//Mina Stanton
//Program Description: This program will recognize invalid inputs using regular expressions. 

using System;
using System.Text.RegularExpressions;

namespace Lab7_Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userContinue = true;
            while (userContinue)
            {
                //sending to user input the first name then to validate names method
                string firstName = ValidateNames(GetUserInput("Please enter your first name: i.e. John"));
                Console.WriteLine($" \n{firstName}\n");

                //sending to user input the last name then to validate names method
                string lastName = ValidateNames(GetUserInput("Please enter your last name: i.e. Jones"));
                Console.WriteLine($" \n{lastName} \n");

                //sending to user input the email then to validate email method
                string email = ValidateEmail(GetUserInput("Please enter your email: i.e. jjones@gmail.com"));
                Console.WriteLine($" \n{email} \n");

                //sending to user input the phone number then to validate phone number
                string phoneNumber = ValidatePhoneNumber(GetUserInput("Please enter your phone number area code first: i.e. 123-123-1234"));
                Console.WriteLine($" \n{phoneNumber} \n");

                //sending to user input the date then to validate Date
                string date = ValidateDate(GetUserInput("Please enter a date: i.e. 01/28/2020"));
                Console.WriteLine($" \n{date} \n");

                //prompting the user that they have finished and asking if they want to continueto add more data
                Console.WriteLine("Great, you have filled in all the data correctly! Would like to enter another data set? (y/n)");
                string userAnswer = Console.ReadLine().ToLower();
                //utilizing a while loop to ensure the user enters a "y" or an "n"
                while(userAnswer != "y" && userAnswer != "n")
                {
                    Console.WriteLine("Please enter y to continue or n to exit.");
                    userAnswer = Console.ReadLine().ToLower();
                }
                //if the user enters an "n" then the loop will exit
                if(userAnswer == "n")
                {
                    break;
                }
            }
            Console.WriteLine("\nOk, thanks for filling out the information. Bye!");
        }
        //this method will get input for the user and return it as a string
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        //this method validates the users name and uses recursion to keep asking the user if they want to continue
        public static string ValidateNames(string name)
        {
            if (Regex.IsMatch(name, @"^[A-Z][a-zA-Z]*$") && name.Length <= 30)
            {
                return "Valid name!";
            }
            else
            {
                Console.WriteLine("Sorry, that name is not valid! Please enter a valid name:");
                return ValidateNames(Console.ReadLine());
            }
        }

        //this method validates the users emai and uses recursion to keep asking the user if they want to continue
        public static string ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, @"^([0-9]|[a-zA-Z]){5,30}@[a-zA-Z]{5,10}(\.(?!\.))[a-zA-Z]{2,3}$"))
            {
                return "Valid email!";
            }
            else
            {
                Console.WriteLine("Sorry, that email is not valid! Please enter a valid email:");
                return ValidateEmail(Console.ReadLine());
            }

        }

        //this method validates the users phone number and uses recursion to keep asking the user if they want to continue
        public static string ValidatePhoneNumber(string phoneNumber)
        {
            if (Regex.IsMatch(phoneNumber, @"^[0-9]{3}-[0-9]{3}-[0-9]{4}$"))
            {
                return "Valid phone number!";
            }
            else
            {
                Console.WriteLine("Sorry, that phone number is not valid! Please enter a valid phone number:");
                return ValidatePhoneNumber(Console.ReadLine());
            }
        }

        //this method validates the users date and uses recursion to keep asking the user if they want to continue
        public static string ValidateDate(string date)
        {
            if (Regex.IsMatch(date, @"^[0-9]{2}(\/(?!\/))[0-9]{2}(\/(?!\/))[0-9]{4}$"))
            {
                return "Valid date!";
            }
            else
            {
                Console.WriteLine("Sorry, that date is not valid! Please enter a valid date:");
                return ValidateDate(Console.ReadLine());
            }
        }
    }
}
