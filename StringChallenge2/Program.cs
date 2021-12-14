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
            string characterToSearch = Console.ReadLine();
            Console.WriteLine(userInput.IndexOf(characterToSearch));

            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            string fullName = string.Format($"{firstName} {lastName}");
            Console.WriteLine(fullName);

        }
    }
}
