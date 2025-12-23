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

            Gun g = new Gun(10, 30);

            g.Shoot();
            Console.WriteLine("Патронов в обойме - " + g.AmmoCount);

            g.Shoot();
            g.Shoot();
            g.Shoot();
            g.Shoot();
            g.Shoot();
            g.Shoot();
            g.Shoot();
            g.Shoot();
            Console.WriteLine("Патронов в обойме - " + g.AmmoCount);

            g.Shoot();
            Console.WriteLine("Патронов в обойме - " + g.AmmoCount);
            g.Shoot();
            g.Shoot();
            g.Shoot();
            g.Reload();
            Console.WriteLine("Патронов в обойме - " + g.AmmoCount);
            g.Shoot();
            g.Shoot();
        }
    }
}
