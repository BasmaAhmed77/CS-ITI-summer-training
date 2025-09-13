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

class Question
{
    private int mark;
    private string header, body;

    public Question()
    {
        header = "No header";
        body = "No body";
        mark = 0;
    }

    public  Question(string h, string b, int m)
    {
        header = h;
        body = b;
        mark = m;
    }

    public void show() 
    {
        Console.WriteLine("Header: " + header);
        Console.WriteLine("Body: " + body);
        Console.WriteLine("Mark: " + mark);
    }  
}

class MCQ : Question
{
    private string[] chooses;
    private int correctIndex;
    public MCQ() : base()
    {
        chooses = new string[] { "No choices" };
        correctIndex = -1;
    }
    public MCQ(string h, string b, int m, string[] c, int ci) : base(h, b, m)
    {
        chooses = c;
        correctIndex = ci;
    }
    public void show()
    {
        base.show();
        Console.WriteLine("Choices: ");
        for (int i = 0; i < chooses.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " + chooses[i]);
        }
        Console.WriteLine("Correct Index: " + correctIndex);
    }
}
class Program
{
    static void Main(string[] args)
    {
        #region class Calc

        Calc calc1 = new Calc();
        Console.WriteLine("The sum of 2 numbers: " + calc1.sum(2, 3));
        Console.WriteLine("The sum of 3 numbers: " + calc1.sum(2, 3, 5));
        Console.WriteLine("The sub of 2 int numbers: " + calc1.sub(10, 3));
        Console.WriteLine("The sub of 2 float numbers: " + calc1.sub(10.5f, 3.7f));
        Console.WriteLine("The mul of 2 numbers: " + calc1.mul(2, 3));
        Console.WriteLine("The div of 2 numbers: " + calc1.div(15, 3));

        #endregion


        #region class question

        Question q1 = new Question();
        Question q2 = new Question("Math", "2+2=?", 5);
        q1.show();
        q2.show();

        #endregion

        #region MCQ class

        MCQ mcq1 = new MCQ();
        mcq1.show();
        string[] choices = { "1", "2", "3", "4" };
        #endregion
    }
}
