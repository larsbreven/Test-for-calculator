using System;

namespace Test_for_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number to be calculated: ");             // Do the calculation and show the result
            double firstNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number to be calculated: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());
            double theResult = firstNum + secondNum;

            double[] calcArray = new double[3];                                         // Definition of an array with 3 elements
            calcArray[0] = firstNum;
            calcArray[1] = secondNum;
            calcArray[2] = theResult;

            OverloadMethod Add = new OverloadMethod();                                  
            double totalSum = Add.Addition(calcArray[0],(calcArray[1]));
            Console.WriteLine("The sum of the calculation is " + totalSum);

        }
    }
}
