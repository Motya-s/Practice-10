using System;

class Animal
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Animal(string name)
    {
        Name = name;
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} издаёт звук.");
    }
}

class Cat : Animal
{
    private int lives;

    public int Lives
    {
        get { return lives; }
        set
        {
            if (value < 1)
                lives = 1;
            else if (value > 9)
                lives = 9;
            else
                lives = value;
        }
    }

    public Cat(string name, int lives) : base(name)
    {
        Lives = lives;
    }

    public Cat(string name) : this(name, 9) { }

    public void Meow()
    {
        if (Lives > 1)
            Lives--;
        Console.WriteLine($"{Name} мяукнул, осталось жизней: {Lives}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cat cat1 = new Cat("Малыш");
        cat1.Speak();
        cat1.Meow();

        Cat cat2 = new Cat("Черныш", 8);
        cat2.Speak();
        cat2.Meow();
    }
}