using System;

class Device
{
    private string brand;

    public string Brand

    {

        get { return brand; }
        set { brand = value; }

    }

    public Device(string brand)

    {

        Brand = brand;

    }

    public void PowerOn()

    {

        Console.WriteLine($"{Brand} включён.");

    }
}

class Laptop : Device
{
    private int ram;
    private int battery;

    public int Ram

    {

        get { return ram; }
        set

        {

            if (value >= 1 && value <= 64)
                ram = value;
            else
            {

                Console.WriteLine("Ошибка: ОЗУ должно быть от 1 до 64 ГБ.");
                ram = 1;

            }
        }
    }

    public int Battery
    {

        get { return battery; }
        set

        {

            if (value >= 0 && value <= 100)
                battery = value;
            else

            {

                Console.WriteLine("Ошибка: заряд должен быть от 0 до 100%.");
                battery = 0;

            }
        }
    }

    public Laptop(string brand, int ram, int battery) : base(brand)

    {

        Ram = ram;
        Battery = battery;

    }

    public void Work()

    {

        Console.WriteLine($"Ноутбук {Brand}, ОЗУ: {Ram} ГБ, заряд: {Battery}%.");

    }
}

class Program
{
    static void Main(string[] args)

    {

        Laptop laptop = new Laptop("Asus", 32, 80);
        laptop.PowerOn();
        laptop.Work();

        laptop.Ram = 0;

    }
}