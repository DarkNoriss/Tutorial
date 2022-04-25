using System;
using System.Linq;

namespace Tutorial {
    class Program {
        static void Main(string[] args) {
            Console.Title = "FirstProgram";
            Console.ForegroundColor = ConsoleColor.Green;

            int userAge;
            string userName, userAnimal;

            if (OperatingSystem.IsWindows()) {
                Console.WindowHeight = 40;
            }

            Console.WriteLine("Yo whats ur name dud?");
            userName = Console.ReadLine();

            if (userName.Any(char.IsDigit)) {
                Console.WriteLine("Thats not a real name dud...");
            }

            Console.WriteLine("I am GOD and im better than u!");
            Console.WriteLine("Whats ur age?");
            userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge <= 18) {
                Console.WriteLine("lol not even an adult KEKW");
            }

            Console.WriteLine("Whats ur fav animal?");
            userAnimal = Console.ReadLine();

            if (userAnimal.Any(char.IsDigit)) {
                Console.WriteLine("Thats not a real animal dud...");
            } else {
                if (userAnimal.Length > 5) {
                    Console.WriteLine("Cool but who asked?");
                } else {
                    Console.WriteLine("Thats nice");
                }
            }

            Console.ReadKey();
        }
    }
}
