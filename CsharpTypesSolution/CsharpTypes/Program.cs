using System;

namespace CsharpTypes {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Welcome to the world's simplest calculator!");
            Console.WriteLine("*********************************************");
            Console.Write("Enter first number: ");
            var nbr1AsStr = Console.ReadLine();
            var nbr1 = Convert.ToInt32(nbr1AsStr);
             
            Console.Write("Enter second number: ");
            var nbr2AsStr = Console.ReadLine();
            var nbr2 = Convert.ToInt32(nbr2AsStr);

            var answer = (nbr1 + nbr2);
            Console.Write($"{nbr1} plus {nbr2} equals {answer}");


            //Console.Write("Enter some data and press ENTER: ");
            //var response = Console.ReadLine();
            //Console.WriteLine(response);

        }
    }
}
