using System;
using System.Runtime.InteropServices;


public struct time
{
    public int hour, min, second;
}
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
            Console.Write("Enter the name of student number " + (i + 1) + ": ");
            students[i] = Console.ReadLine();
        }
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"The name of student {i + 1}: {students[i]}");
        }



        #endregion




        #region student age for each track
        Console.Write("Enter number of students: ");
        int studentsNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number of tracks: ");
        int tracksNum = Convert.ToInt32(Console.ReadLine());
        int[,] ages = new int[tracksNum, studentsNum];
        int[] sum = new int[studentsNum];
        for (int i = 0; i < tracksNum; i++)
        {
            for (int j = 0; j < studentsNum; j++)
            {
                Console.Write($"Enter age of student {j + 1} in track {i + 1}: ");
                ages[i, j] = Convert.ToInt32(Console.ReadLine());
                sum[i] += ages[i, j];
            }
        }
        for (int i = 0; i < tracksNum; i++)
        {
            for (int j = 0; j < studentsNum; j++)
            {
                Console.WriteLine($"Age of Student {j + 1} in track {i + 1}: {ages[i, j]}");
            }
        }
        for (int i = 0; i < tracksNum; i++)
        {
            Console.WriteLine($"Avg age of Track {i + 1}: {sum[i] / studentsNum}");
        }



        #endregion


        #region time format

        time time1;
        Console.Write("Enter hour: ");
        time1.hour = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter minute: ");
        time1.min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second: ");
        time1.second = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{time1.hour}H:{time1.min}M:{time1.second}S");
        #endregion

    }
}