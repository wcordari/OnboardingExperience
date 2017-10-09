using System;
using System.Reflection;
using System.Threading;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            Console.WriteLine("What up doe! Welcome to our onboarding experience");

            user.FirstName = AskQuestion("What is your first name homie? ");
            Console.WriteLine("Great! Your name is " + user.FirstName);

            user.LastName = AskQuestion("What is your last name?");
            Console.WriteLine("Word! Your full name is " + user.FirstName + " " + user.LastName);

            user.IsAccountOwner = AskBoolQuestion("Are you the account owner or are you a thief?");
            Console.WriteLine("Awesome! You are the account owner: " + user.IsAccountOwner);

            user.PinNumber = AskPinNumber(" What is your 4-digit pin dont lie?", 4);
            Console.WriteLine("Awesome! You entered: " + user.PinNumber);

            Console.ReadLine();
        }

        static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static bool AskBoolQuestion(string question)
        {
            var hasAnswered = false;
            var responseBool = false;

            while (!hasAnswered)
            {
                var response = AskQuestion(question + "(y/n)");

                if (response == "y")
                {
                    responseBool = true;
                    hasAnswered = true;
                }
                else if (response == "n")
                {
                    responseBool = false;
                    hasAnswered = true;
                }
            }
            return responseBool;
        }

        static string AskPinNumber(string question, int length)
        {
             string numberString = null;

            while (numberString == null)
            {
                var response = AskQuestion(question);

                if (response.Length == length && Int32.TryParse(response, out int _))
                {
                    numberString = response;
                }

            }

            return numberString;
        }
    }

}
        