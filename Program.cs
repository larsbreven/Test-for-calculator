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
            Console.WriteLine("The result of the calculation is: " + theResult);

            double[] calcArray = new double[3];                                         // Definition of an array with 3 elements
            calcArray[0] = firstNum;
            calcArray[1] = secondNum;
            calcArray[2] = theResult;
         
            double sumArray = calcArray[0] + calcArray[1];                              // Input taken from the array + show the result
            Console.WriteLine("The calculated result from the array is :" + sumArray);


         /*   foreach (double value in calcArray)                                         // The loop can be used to show the values
            {
                Console.WriteLine();
                Console.WriteLine("The values from the keyboard to the array are " + value);
            } */
        }


    }
}
