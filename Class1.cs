using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1
{
    /* Class for Arithmetic Opertions*/

    /// <summary>
    /// The Arithmetic class
    /// Contains all the basic arithmetic methods
    /// </summary>
    /// <remarks>
    /// <para>This class has methods for Addition, Substraction, Multiplication and Divison.</para>
    /// </remarks>

    ///<list type="bullet">
    /// <item>
    /// <term>Add</term>
    /// <description>Addition Operation</description>
    /// </item>
    /// <item>
    /// <term>Subtract</term>
    /// <description>Subtraction Operation</description>
    /// </item>
    /// <item>
    /// <term>Multiply</term>
    /// <description>Multiplication Operation</description>
    /// </item>
    /// <item>
    /// <term>Divide</term>
    /// <description>Division Operation</description>
    /// </item>
    /// </list>
 

    public class Arithmetic
    {
        /// <summary>
        /// Adds two numbers and returns the sum
        /// </summary>
        /// <param name="Number1">An intger type</param>
        /// <param name="Number2">An intger type</param>
        ///<returns>
        ///<para>returns the sum of two numbers</para>
        ///</returns>
        ///<example>
        ///<code>
        ///int sum=Arithmetic.Add(9,10)
        ///Console.WriteLine(sum);
        ///</code>
        /// </example>
        /// <exception cref="OverflowException">Occurs when one of the number is more than the integer value</exception>
        public int Add(int Number1, int Number2)
        {
            if ((Number1 == int.MaxValue && Number2 > 0) || (Number2 == int.MaxValue && Number1 > 0))
                throw new System.OverflowException();

            return Number1 + Number2;
        }


        /// <summary>
        /// Substracts two numbers and returns the difference
        /// </summary>
        /// <param name="Number1">An intger type</param>
        /// <param name="Number2">An intger type</param>
        /// <returns>
        /// <para>returns of difference of two numbers</para>
        /// </returns>
        ///<example>
        ///<code>
        ///int Difference=Arithmetic.Substract(19,10)
        ///Console.WriteLine(Difference);
        ///</code>
        ///</example>
        public int Substract(int Number1, int Number2)
        {
            return Number1 - Number2;
        }


        /// <summary>
        /// Multiplies two numbers and returns the product
        /// </summary>
        /// <param name="Number1">An intger type</param>
        /// <param name="Number2">An intger type</param>
        /// <returns>
        /// <para>returns the product of two numbers</para>
        /// </returns>
        ///<example>
        ///<code>
        ///int Product=Arithmetic.Multiply(9,10)
        ///Console.WriteLine(Product);
        ///</code>
        ///</example>
        ///<exception cref="OverflowException">Occurs when one of the number is more than the integer value</exception>

        public int Multiply(int Number1, int Number2)
        {
            if ((Number1 == int.MaxValue && Number2 > 0) || (Number2 == int.MaxValue && Number1 > 0))
                throw new System.OverflowException();

            return Number2 * Number1;
        }

        /// <summary>
        /// Divides two numbers and returns the quotient
        /// </summary>
        /// <param name="Number1">An intger type</param>
        /// <param name="Number2">An intger type</param>
        /// <returns>
        /// <para>returns the quotient of two numbers</para>
        /// </returns>
        ///<example>
        ///<code>
        ///int Quotient=Arithmetic.Divide(9,10)
        ///Console.WriteLine(Quotient);
        ///</code>
        ///</example>
        ///<exception cref="DivideByZeroException"> Occurs when a number is attemted to be divided by zero</exception>
        public int Divide(int Number1, int Number2)
        {
            if (Number2 == 0)
                throw new DivideByZeroException();
                    
            return Number1 / Number2;
        }
    }
}
