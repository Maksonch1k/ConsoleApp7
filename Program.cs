using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Введите месяц: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Введите день: ");
            int day = int.Parse(Console.ReadLine());

            DateClass dateObject = new DateClass(year, month, day);

            Console.WriteLine($"Текущая дата: {dateObject.Data}");
            Console.WriteLine($"Предыдущий день: {dateObject.PreviousDay()}");
            Console.WriteLine($"Следующий день: {dateObject.NextDay()}");
            Console.WriteLine($"Дней до конца месяца: {dateObject.DaysLeft()}");
            Console.ReadKey();
        }
    }

}
    
