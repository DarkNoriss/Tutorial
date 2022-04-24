using System;

namespace Tutorial {
    class Program {
        static void Main(string[] args) {
            Console.Title = "FirstProgram";
            Console.ForegroundColor = ConsoleColor.Green;
            if (OperatingSystem.IsWindows()) {
                Console.WindowHeight = 40;
            }

            Console.WriteLine("Yo whats ur name dud?");

            Console.ReadLine();

            Console.WriteLine("I am GOD \nand im better than u!");
            Console.WriteLine("Whats ur fav animal?");
            if (Console.ReadLine().Length > 5) {
                Console.WriteLine("Cool but who asked?");
            }

            Console.WriteLine("Thats nice");

            Console.ReadKey();

        }
    }
}
