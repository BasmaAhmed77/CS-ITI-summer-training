using System;

class Engine
{
    public string Type { get; set; }
    public Engine(string type)
    {
        Type = type;
    }
    public void show()
    {
        Console.WriteLine($"Engine Type: {Type}"); 
    }
}
class Car
{
    public string Model { get; set; }
    public int Year { get; set; }

    public Engine engine { get; set; }
    public Car(string model, int year, Engine eng)
    {
        Model = model;
        Year = year;
        engine = eng;
    }
    public void show()
    {
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
        engine.show();
    }
}
class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }

    public string [] courses;

    public Department department { get; set; }
    public Employee(string name, int age, Department depart, string[] courses)
    {
        Name = name;
        department = depart;
        this.courses = courses;
    }
    public void show()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Department: {department}");

        for (int i = 0; i < department.EmployeeCount; i++)
        {
            Console.WriteLine($"Course {i + 1}: {courses[i]}");
        }

    }
}

class Department
{
    public string Name { get; set; }
    public int EmployeeCount { get; set; }

    List<Employee> employees = new List<Employee>();

    List <Instructor> instructors = new List<Instructor>();
    public Department(string name, int employeeCount)
    {
        Name = name;
        EmployeeCount = employeeCount;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Department Name: {Name}");
        Console.WriteLine($"Employee Count: {EmployeeCount}");
    }
}

class Company
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }

    List <Department> departments = new List<Department>();
    public Company(string name, string address, string phone)
    {
        Name = name;
        Address = address;
        Phone = phone;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Company Name: {Name}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Phone: {Phone}");
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}

class Student : Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Major { get; set; }
    List<string> courses = new List<string>();
    public Student(string name, int age, string major)
    {
        Name = name;
        Age = age;
        Major = major;
    }
    public void show()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Major: {Major}");
    }

    public void RegisterCourse(string course)
    {
        courses.Add(course);
    }
}

class Instructor : Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Subject { get; set; }
    List<string> courses = new List<string>();
    public Instructor(string name, int age, string subject)
    {
        Name = name;
        Age = age;
        Subject = subject;
    }

    public void TeachCourse(string course)
    {
        courses.Add(course);
    }
    public void show()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Subject: {Subject}");
    }
}

class Course
{
    public string Title { get; set; }
    public int Credits { get; set; }
    public Instructor instructor { get; set; }
    List<Student> students = new List<Student>();
    public Course(string title, int credits, Instructor instructor)
    {
        Title = title;
        Credits = credits;
        this.instructor = instructor;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Course Title: {Title}");
        Console.WriteLine($"Credits: {Credits}");
        Console.WriteLine($"Instructor: {instructor.Name}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        
    }
}