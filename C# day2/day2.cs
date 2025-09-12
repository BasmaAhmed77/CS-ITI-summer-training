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

        #endregion student age for each track
        Console.Write("Enter number of students: ");
        int studentsNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number of tracks: ");
        int tracksNum = Convert.ToInt32(Console.ReadLine());
        int[,] ages = new int[tracksNum,studentsNum];
        int[] sum = new int[studentsNum];
        for (int i=0; i<tracksNum; i++)
        {
            for(int j = 0; j < studentsNum; j++)
            {
                Console.Write($"Enter age of student {j+1} in track {i+1}: ");
                ages[i,j] = Convert.ToInt32(Console.ReadLine());
                sum[i] += ages[i,j];
            }
        }
        for (int i = 0; i < tracksNum; i++)
        {
            for (int j = 0; j < studentsNum; j++)
            {
                Console.WriteLine($"Age of Student {j+1} in track {i+1}: {ages[i,j]}");
            }
        }
        for (int i = 0; i < tracksNum; i++)
        {
            Console.WriteLine($"Avg age of Track {i + 1}: {sum[i]/studentsNum}");
        }
        #region


        #endregion


        #region time format



        #endregion

    }
}
