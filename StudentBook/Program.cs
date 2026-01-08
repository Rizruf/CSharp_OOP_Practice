namespace StudentBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Пиво");

            student.Add("Математика", 3);
            student.Add("ООП", 5);
            student.Add("Физра", 4);
            student.Add("Физика", 5);
            student.Add("Английский", 2);

            student.PrintInfo();
        }
    }
}
