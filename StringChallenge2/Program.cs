using System;

namespace StringChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string here: ");
            string userInput = Console.ReadLine();
            Console.Write("Enter the character to search: ");
            char characterToSearch = Console.ReadLine()[0];
            int indexOfCharacter = userInput.IndexOf(characterToSearch);
            Console.WriteLine($"Index of character {characterToSearch} is {indexOfCharacter}");

            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine($"Your full name is: {fullName}");

        }
    }
}
