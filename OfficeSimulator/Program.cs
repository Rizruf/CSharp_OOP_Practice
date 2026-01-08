namespace OfficeSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Office office = new Office();

            
            office.Add(new Manager("Борис"));
            office.Add(new Developer("Олег"));
            office.Add(new Intern("Вася"));

            office.StartWorkDay();
        }
    }
}
