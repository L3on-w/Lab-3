using System;

namespace Lab_3
{
    class MainClass
    {
        public static void Main(string[] args)
            //Asking the user for their first name to address them throughout the program
        {
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();
            // Asking user to input a number between 1 and 100
            Console.WriteLine(firstname +" " +"please choose a number between 1 and 100");
            string userInputNumber = Console.ReadLine();
            int number = int.Parse(userInputNumber);
            bool askUserQuestionAgain = true;
            


            if (number % 2 != 0)
            {
                Console.WriteLine(userInputNumber +" "+ "odd");
            }
            else if (number % 2 == 0 && number >= 2 && number < 25)
            {
                Console.WriteLine("even and less than 25");
            }
            else if (number % 2 == 0 && number >= 26 && number <= 60)
            {
                Console.WriteLine("Even");
            }
            else if (number % 2 == 0 && number > 60)
            {
                Console.WriteLine(userInputNumber +" "+ "Even");
            }
            else if (number % 2 != 0 && number > 60)
            {
                Console.WriteLine(userInputNumber +" " +"Odd");
            }

            //Asking the user if they would like to enter another number
            //if yes ask original question again, else (no) end the program
            while (askUserQuestionAgain)
            {
                Console.WriteLine("Would you like to enter another number?");
                string response = Console.ReadLine();

                if (response == "yes")
                {
                    Console.WriteLine(firstname + " " + "please choose a number between 1 and 100");
                }
                else 
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
            }
        }
    }
}
