using System;

class Book
{
    private string title;
    private int pages;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public int Pages
    {
        get { return pages; }
        set
        {
            if (value >= 1 && value <= 5000)
                pages = value;
            else
            {
                Console.WriteLine("Ошибка: количество страниц должно быть от 1 до 5000.");
                pages = 1;
            }
        }
    }

    public Book(string title, int pages)
    {
        Title = title;
        Pages = pages;
    }

    public Book(string title) : this(title, 100) { }

    public Book() : this("Без названия", 1) { }

    public void Read()
    {
        Console.WriteLine($"Читаю книгу \"{Title}\", страниц: {Pages}.");
    }
}

class Program
{

    static void Main(string[] args)

    {

        Book b1 = new Book("Гарри Поттер", 1000);
        Book b2 = new Book("Шерлок Холмс");
        Book b3 = new Book();

        b1.Read();
        b2.Read();
        b3.Read();

        b1.Pages = 0; 
        

    }
}