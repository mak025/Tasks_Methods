using System.Diagnostics;

namespace Beep
{
    internal class Program
    {
        public static void Beep(int count, int sleep)
        {
            for(int i = 0; i <= count; i++)
            {
                Console.Beep(300, 300);
            }
            Thread.Sleep(sleep + 1000);
        }
        static void Main(string[] args)

        {
            Console.WriteLine("Please enter the amount of times you wish the alarm to beep");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the timespan of which you want the alarm to go on for");
            int sleep = int.Parse(Console.ReadLine());
            Beep(count, sleep);

        }
    }
}
