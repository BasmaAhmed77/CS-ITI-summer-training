using System;
using System.Runtime.InteropServices;




class Program
{
    static void Main(string[] args)
    {
        #region Input number of students and their names
        Console.Write("Enter number of students: ");
        int size = Convert.ToInt32(Console.ReadLine());
        string[] students = new string[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter the name of student number "+(i+1) + ": ");
            students[i] = Console.ReadLine();
        }
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"The name of student {i+1}: {students[i]}");
        }


        
        #endregion



        #region


        #endregion


        #region time format

       

        #endregion

    }
}
