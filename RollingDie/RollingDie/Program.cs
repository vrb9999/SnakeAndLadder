using System;

namespace RollingDie
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = 0;
            Random random = new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine("Player Position : " + position + "  Die rolled : " + dice);
        }
    }
}
