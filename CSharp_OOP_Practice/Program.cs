namespace CSharp_OOP_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Passport p = new Passport("Асуханов Игорь Юрьевич", "5200 123456", new DateOnly(2022, 05, 20));

            p.Print_Info();
        }
    }
}
