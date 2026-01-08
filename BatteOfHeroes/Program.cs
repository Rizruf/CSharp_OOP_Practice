namespace BatteOfHeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Unit> arena = new List<Unit>();

            arena.Add(new Warrior("Черный", 100, 10, 5));
            arena.Add(new Mage("Красный", 80, 20, 2));
            arena.Add(new Barbarian("Желтый", 120, 15, 0));

            Random rnd = new Random();

            while (arena.Count > 1)
            {
                int index1 = rnd.Next(arena.Count);
                int index2 = rnd.Next(arena.Count);

                if (index1 == index2) continue; 

                Unit attacker = arena[index1];
                Unit defender = arena[index2];

                attacker.Attack(defender);

                
                if (defender.Health <= 0)
                {
                    Console.WriteLine($"{defender.Name} погиб!");
                    arena.RemoveAt(index2);
                }

                Thread.Sleep(500);
            }

            Console.WriteLine($"Победитель: {arena[0].Name}!");
        }

    }
}
