
using System;
class Program
{
    static void Main(string[] args)
    {

        #region char to its ASCII code
        Console.Write("Enter a character: ");
        char ch = Convert.ToChar(Console.ReadLine());
        Console.WriteLine($"The char in ASCII code is: {Convert.ToInt32(ch)}");
        #endregion


        #region   the ASCII code to its char
        Console.Write("Enter the ASCII code of the char: ");
        int ascii = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("the char is: "+Convert.ToChar(ascii));
        #endregion


        #region odd or even num?

        Console.Write("Enter a number: ");
        int num= Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
            Console.WriteLine("Number is even.");
        else
            Console.WriteLine("Number is odd.");

        #endregion


        #region sum, subtraction & multiplication of 2 numbers

        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sum = "+(num1+num2));
        Console.WriteLine($"Subtraction = {num1-num2}");
        Console.WriteLine("Multiplication = " + (num1 * num2));

        #endregion


        #region Grades

        Console.Write("Enter your degree: ");
        int degree = Convert.ToInt32(Console.ReadLine());
        if(degree>=85)
            Console.WriteLine("Your grade is: A");
        else if (degree >= 75)
            Console.WriteLine("Your grade is: B");
        else if (degree >= 65)
            Console.WriteLine("Your grade is: C");
        else if (degree >= 50)
            Console.WriteLine("Your grade is: D");
        else
            Console.WriteLine("Your grade is: F");

        #endregion


        #region  Multiplication table
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(number + "x" + i + "=" + (number*i));
        }
        #endregion


    }
}
