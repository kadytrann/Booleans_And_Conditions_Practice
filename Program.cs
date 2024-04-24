namespace Booleans_And_Conditions_Practice
/*
 Kady Tran
04/24/2024
*/

{
    internal class Program
    {
        static void Main(string[] args)
        {


            Menu();

        } // End of main

        public static void Part1()
        {
            Console.WriteLine("Part 1"); // Label for organization

            int userTemperatureInF = 0;

            // Prompt the user to enter a temperature inside Try / Catch in case user enters an invalid value

            try
            {
                Console.Write("Please enter a temperature (°F): ");
                string userTemperatureInput = Console.ReadLine();
                userTemperatureInF = int.Parse(userTemperatureInput);
            }
            catch
            {
                Console.WriteLine("Your temperature was invalid.");
            }

            // Display a different message depending on the temperature.
            Console.WriteLine("Your temperature is " + userTemperatureInF + "°F.");
            if (userTemperatureInF <= 32)
            {
                Console.WriteLine("That's freezing, be careful out there.");
            }
            else if (userTemperatureInF >= 33 && userTemperatureInF <= 50)
            {
                Console.WriteLine("It's really cold out, bring a jacket.");
            }
            else if (userTemperatureInF >= 51 && userTemperatureInF <= 68)
            {
                Console.WriteLine("It's starting to get cold. A sweater should work.");
            }
            else if (userTemperatureInF >= 69 && userTemperatureInF <= 75)
            {
                Console.WriteLine("It's comfortable out. A shirt and jeans will work.");
            }
            else if (userTemperatureInF >= 76)
            {
                Console.WriteLine("It's T-shirt and shorts time");
            }

        } // End of part1

        public static void Part2()
        {
            Console.WriteLine("Part 2");

            // Prompts the user to enter an integer
            Console.Write("Please enter a whole number: ");
            int userNumber = int.Parse(Console.ReadLine());

            // Using a conditional statement to determine whether the number is odd or even by dividing the userNumber by 2 and seeing if it has any remainder, if it doesn't have a remainder, it's even, and if it does then it's odd.
            if (userNumber % 2 == 0)
            {
                Console.WriteLine("Your number is " + userNumber + ", and it's even"); // Printing out the user number and that it's even
            }
            else
            {
                Console.WriteLine("Your number is " + userNumber + ", and it's odd"); // // Printing out the user number and that it's odd
            }

        } // End of part2

        public static void Part3()
        {
            Console.WriteLine("Part 3");

            // Prompt the user to enter a year.
            Console.Write("Please enter a year: ");
            int userYear = int.Parse(Console.ReadLine());

            // If statement with the following criteria to determine whether the year is a leap year:
            // A year is a leap year if it is divisible by 4, except for years that are divisible by 100.
            // However, years that are divisible by 400 are also leap years.
            if (userYear % 4 == 0)
            {
                Console.WriteLine(userYear + " is a leap year."); // Prints a message indicating the year is a leap year
            }
            else if (userYear % 400 == 0)
            {
                Console.WriteLine(userYear + " is a leap year.");
            }
            else
            {
                Console.WriteLine(userYear + " is not a leap year."); // Prints a message indicating the year is not a leap year
            }

        }

        public static void Menu()
        {
            Console.WriteLine("Welcome to Code Practice - Booleans and Conditions!");
            Console.WriteLine("Which would you like to run?");
            Console.WriteLine("1 - Temperature");
            Console.WriteLine("2 - Odd or Even");
            Console.WriteLine("3 - Leap Year Checker");
            Console.WriteLine("4 - Exit");
            Console.Write("Enter your choice: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Part1();
            }
            else if (userInput == "2")
            {
                Part2();
            }
            else if (userInput == "3"){
                Part3();
            }
            else
            {
                Console.WriteLine("Thank you and have a great day");
                Console.ReadKey();
            } // End of menu


        } 
    }// End of class
}// End of namespace
