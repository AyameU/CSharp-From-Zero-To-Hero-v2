using System;

namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person 1
            GetUserInfo();
            // Person 2
            GetUserInfo();
        }

        /// <summary>
        /// Prompts the user to enter their information.
        /// </summary>
        static void GetUserInfo()
        {
            string name = ReadFromConsole("name");
            string surname = ReadFromConsole("surname");
            string age = ReadFromConsole("age");
            string weightInput = ReadFromConsole("weight in kg");
            double weight = ConvertToDouble(weightInput);
            string heightInput = ReadFromConsole("height in cm");
            double height = ConvertToDouble(heightInput);
            PrintUserInfo(name, surname, age, weight, height);
            PrintBMI(name, CalculateBMI(weight, height));
        }

        /// <summary>
        /// Reads user input from the console.
        /// </summary>
        /// <param name="inputType">The input type the user should enter.</param>
        /// <returns>The user's input.</returns>
        static string ReadFromConsole(string inputType)
        {
            Console.Write($"Please enter a(n) {inputType}: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Converts a string to a double.
        /// </summary>
        /// <param name="input">The string to be converted.</param>
        /// <returns>A double.</returns>
        static double ConvertToDouble(string input)
        {
            double converted = double.Parse(input);
            return converted;
        }

        /// <summary>
        /// Prints the users information to the console.
        /// </summary>
        /// <param name="name">The user's first name.</param>
        /// <param name="surname">The user's surname.</param>
        /// <param name="age">The user's age.</param>
        /// <param name="weight">The user's weight.</param>
        /// <param name="height">The user's height.</param>
        static void PrintUserInfo(string name, string surname, string age, double weight, double height)
        {
            Console.WriteLine($"{name} {surname} is {age} years old, they are {height} cm tall and weigh {weight} kg.");
        }

        /// <summary>
        /// Calculates a user's body mass index.
        /// </summary>
        /// <param name="weight">A user's height.</param>
        /// <param name="height">A user's weight.</param>
        /// <returns>The calculated body mass index.</returns>
        static double CalculateBMI(double weight, double height)
        {
            double metres = height / 100;
            double bmi = weight / (metres * metres);
            return bmi;
        }

        /// <summary>
        /// Prints a user's body mass index to the console.
        /// </summary>
        /// <param name="name">The user's name.</param>
        /// <param name="bmi">The user's body mass index.</param>
        static void PrintBMI(string name, double bmi)
        {
            Console.WriteLine($"{name}'s BMI is {bmi:n}.\n");
        }
    }
}