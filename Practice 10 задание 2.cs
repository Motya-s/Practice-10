using System;

class Employee
{

    private string name;
    private double salary;

    public string Name
    {

        get { return name; }
        set { name = value; }

    }

    public double Salary
    {

        get { return salary; }
        set

        {

            if (value >= 0 && value <= 1_000_000)
                salary = value;
            else
            {

                Console.WriteLine("Ошибка: Зарплата не может быть отрицательной!");
                salary = 0;

            }

        }
    }

    public Employee(string name, double salary)

    {

        Name = name;
        Salary = salary;

    }

    public Employee(string name) : this(name, 50_000) { }

    public void Work()

    {
        Console.WriteLine($"{Name} работает, зарплата: {Salary} руб.");

    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee("Матвей", 80000);
        Employee e2 = new Employee("Иван");

        e1.Work();
        e2.Work();

        e1.Salary = -1000; 
       
    }
}