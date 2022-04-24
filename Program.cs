using System;
using System.Linq;

namespace Tutorial {
    class Program {
        static void Main(string[] args) {
            Console.Title = "FirstProgram";
            Console.ForegroundColor = ConsoleColor.Green;
            if (OperatingSystem.IsWindows()) {
                Console.WindowHeight = 40;
            }
            Console.WriteLine("Yo whats ur name dud?");
            string nameUser = Console.ReadLine();
            if (nameUser.Any(char.IsDigit)) {
                Console.WriteLine("Thats not a real name dud...");
            }
            Console.WriteLine("I am GOD and im better than u!");
            Console.WriteLine("Whats ur fav animal?");
            string nameAnimal = Console.ReadLine();
            if (nameUser.Any(char.IsDigit)) {
                Console.WriteLine("Thats not a real animal dud...");
            } else {
                if (nameAnimal.Length > 5) {
                    Console.WriteLine("Cool but who asked?");
                } else {
                    Console.WriteLine("Thats nice");
                }
            }
            Console.ReadKey();
        }
    }
}
