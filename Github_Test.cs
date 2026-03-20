using System;
using System.Collections.Generic;

namespace GitHubTestProject
{
    class Program //test1
    {
        static void Main(string[] args) //test2
        {
            Console.WriteLine("========================================"); //asdfasdf
            Console.WriteLine("   Welcome to C# Character Creator!   ");
            Console.WriteLine("========================================\n");

            Console.Write("Enter your character name: ");
            string name = Console.ReadLine();

            Console.WriteLine("\nChoose your job:");
            Console.WriteLine("1. Warrior (High HP)");
            Console.WriteLine("2. Mage (High Mana)");
            Console.WriteLine("3. Rogue (High Speed)");
            Console.Write("Selection (1-3): ");
            
            string choice = Console.ReadLine();
            string job = choice switch
            {
                "1" => "Warrior",
                "2" => "Mage",
                "3" => "Rogue",
                _ => "Novice"
            };

            // 랜덤 능력치 생성
            Random rand = new Random();
            int strength = rand.Next(5, 15);
            int intelligence = rand.Next(5, 15);

            Console.WriteLine("\n--- Character Created! ---");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Job: {job}");
            Console.WriteLine($"Strength: {strength}");
            Console.WriteLine($"Intelligence: {intelligence}");
            Console.WriteLine("--------------------------\n");

            Console.WriteLine("Press any key to exit and upload this to GitHub!");
            Console.ReadKey();
        }
    }
}