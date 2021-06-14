using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.project
{
    public class InputProcessor
    {
        public InputModel ProcessInput(string calculationString)
        {
            //0. Remove all empty spaces
            calculationString = calculationString.Replace(" ", "");

            //1 Find position of first non-member
            char nonNumericValue = calculationString.First(c => !Char.IsDigit(c));

            //2. Split string into 3 parts
            var numbers = calculationString.Split(nonNumericValue);

            //3. Int.Parse both numbers
            int number1 = Int32.Parse(numbers[0]);
            int number2 = Int32.Parse(numbers[1]);

            //4. Map function to InputString

            return new InputModel
            {
                FirstNumber = number1, 
                SecondNumber = number2, 
                Operation = nonNumericValue
            };

        }
    }
}
