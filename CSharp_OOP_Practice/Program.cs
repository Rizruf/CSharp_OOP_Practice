using System.Net.Mail;

namespace CSharp_OOP_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Passport p = new Passport("Асуханов Игорь Юрьевич", "5200 123456", new DateOnly(2022, 05, 20));

            //p.Print_Info();

            //Temperature t = new Temperature();

            //Console.WriteLine("Пробуем задать -300:");
            //t.Celsius_Сheck = -300;

            //Console.WriteLine("Пробуем задать 25:");
            //t.Celsius_Сheck = 25;

            //Console.WriteLine($"В Цельсиях: {t.Celsius_Сheck}");

            //Console.WriteLine($"В Фаренгейтах: {t.Fahrenheit}");

            //Gun g = new Gun(10, 30);

            //g.Shoot();
            //Console.WriteLine("Патронов в обойме - " + g.AmmoCount);

            //g.Shoot();
            //g.Shoot();
            //g.Shoot();
            //g.Shoot();
            //g.Shoot();
            //g.Shoot();
            //g.Shoot();
            //g.Shoot();
            //Console.WriteLine("Патронов в обойме - " + g.AmmoCount);

            //g.Shoot();
            //Console.WriteLine("Патронов в обойме - " + g.AmmoCount);
            //g.Shoot();
            //g.Shoot();
            //g.Shoot();
            //g.Reload();
            //Console.WriteLine("Патронов в обойме - " + g.AmmoCount);
            //g.Shoot();
            //g.Shoot();

            //List<Book> booksList = new List<Book>();

            //booksList.Add(new Book("Властелин Колец", "Толкин"));
            //booksList.Add(new Book("Метро 2033", "Глуховский"));

            //foreach (Book book in booksList)
            //{
            //    Console.WriteLine(book.Title + " || " + book.Author);
            //}

            //Console.WriteLine(MathUtils.Add(10, 20));

            //List<Animal> zoo = new List<Animal>
            //{
            //    new Animal(),
            //    new Dog(),
            //    new Cat(),
            //    new Tiger()
            //};

            //Console.WriteLine("Звуки");

            //foreach (Animal animal in zoo)
            //{
            //    Console.Write("Зверь кричит: ");
            //    animal.Voice();
            //}

            Hero h = new Hero();

            //h.Attack();
            //h.Attack("Меч");
            //h.Attack("Огонь", "пиво");

            h.Hit(50);
        }
    }
}
