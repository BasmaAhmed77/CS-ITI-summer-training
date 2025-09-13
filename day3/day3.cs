using System;


class Calc
{
    private int num1, num2, num3;

    public int sum(int n1, int n2)
    {
        return n1 + n2;
    }
    public int sum(int n1, int n2, int n3)
    {
        return n1 + n2 + n3;
    }

    public int sub(int n1, int n2)
    {
        return n1 - n2;
    }
    public float sub(float n1, float n2)
    {
        return n1 - n2;
    }

    public int mul(int n1, int n2)
    {
        return n1 * n2;
    }
    public int div(int n1, int n2)
    {
        return n1 / n2;
    }

}
class Program
{
    static void Main(string[] args)
    {
        Calc calc1 = new Calc();
        Console.WriteLine("The sum of 2 numbers: "+calc1.sum(2,3));
        Console.WriteLine("The sum of 3 numbers: "+calc1.sum(2,3,5));
        Console.WriteLine("The sub of 2 int numbers: "+calc1.sub(10,3));
        Console.WriteLine("The sub of 2 float numbers: "+calc1.sub(10.5f,3.7f));
        Console.WriteLine("The mul of 2 numbers: "+calc1.mul(2,3));
        Console.WriteLine("The div of 2 numbers: " + calc1.div(15,3));
    }
}
