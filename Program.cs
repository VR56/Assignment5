using System;

namespace Project_1
{
    /// <summary>
    /// This is the main class where all the methods are declared and implemented.
    /// </summary>
    /// <remarks>
    /// This class can add and print the sum.
    /// </remarks>
    class Program
    {
        public static void Main()
        {
            Arithmetic obj = new Arithmetic();
            int number_1, number_2;
            int sum = 0, Difference=0, Product=0,Quotient=0;
            Console.WriteLine("Enter the first number");
            number_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            number_2 = Convert.ToInt32(Console.ReadLine());

            sum = obj.Add(number_1, number_2);
            Difference = obj.Substract(number_1, number_2);
            Product = obj.Multiply(number_1, number_2);
            Quotient = obj.Divide(number_1, number_2);

            Console.WriteLine("The sum is "+sum+"   The Difference is "+Difference+"   The Product is "+Product+"   The Quotient is "+Quotient);
            Console.ReadLine();
  
        }


    }
}
