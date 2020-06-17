using System;

namespace CsharpTypes {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Welcome to the world's simplest calculator!");
            Console.WriteLine("*********************************************");
            Console.Write("Enter first number: ");
            var nbr1AsStr = Console.ReadLine();
            var nbr1 = Convert.ToInt32(nbr1AsStr);
            
            if(nbr1 < 100 || nbr1 > 999) { 
                Console.WriteLine("ERROR: You must enter a number between 100 and 999");
                return;
            }

            Console.Write("Enter second number: ");
            var nbr2AsStr = Console.ReadLine();
            var nbr2 = Convert.ToInt32(nbr2AsStr);

            if (nbr2 > 1000) {
                Console.WriteLine("ERROR: You must enter a number <= 1000");
                return;
            }

            var answer = (nbr1 + nbr2);
            Console.Write($"{nbr1} plus {nbr2} equals {answer}");


            //Console.Write("Enter some data and press ENTER: ");
            //var response = Console.ReadLine();
            //Console.WriteLine(response);

        }
    }
}
