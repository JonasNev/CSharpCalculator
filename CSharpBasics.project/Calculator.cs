using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.project
{
     public class Calculator
     {
         public int ProcessCalculation(InputModel inputModel)
         {
             if (inputModel.Operation == '+')
             {
                 return inputModel.FirstNumber + inputModel.SecondNumber;
             }
             if (inputModel.Operation == '-')
             {
                return inputModel.FirstNumber - inputModel.SecondNumber;
             }
             if (inputModel.Operation == '*')
             {
                 return inputModel.FirstNumber * inputModel.SecondNumber;
             }

             if (inputModel.Operation == '/')
             {
                 return inputModel.FirstNumber / inputModel.SecondNumber;
             }

             //If done with switch
             //switch (inputModel.Operation)
             //{
                 //case '+':
                     //return inputModel.FirstNumber + inputModel.SecondNumber;
                 //case '-':
                     //return inputModel.FirstNumber - inputModel.SecondNumber;
                 //case '*':
                     //return inputModel.FirstNumber * inputModel.SecondNumber;
                 //case '/':
                     //return inputModel.FirstNumber / inputModel.SecondNumber;
                 //default:
                     //return 0;
             //}

            return 0;
         }
     }
}
