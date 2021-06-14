using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Transactions;

namespace CSharpBasics.project
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputProcessor = new InputProcessor();
            var calculator = new Calculator();
            string command = "";
            while (command != "Exit")
            {


                //Console based calculator
                //Calculator should be simple just add/subtract
                //Possible imputs: 5 + 6, 0 - 2
                //Output results
                // The calculator should keep running until 'exit' is typed

                Console.WriteLine("Enter calculation");

                var consoleInput = Console.ReadLine();

                InputModel parsedInput = inputProcessor.ProcessInput(consoleInput);
                var number = calculator.ProcessCalculation(parsedInput);
                Console.WriteLine(number);
                Console.WriteLine("Type Exit if you want to exit or any button to continue");
                command = Console.ReadLine();
            }
        }

    }

}
