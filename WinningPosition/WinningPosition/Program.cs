using System;

namespace WinningPosition
{
    class Program
    {
        public const int ladder = 1;
        public const int snake = 2;
        static void Main(string[] args)
        {
            int position = 0;
            while (position < 100)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                int option = random.Next(0, 3);
                switch (option)
                {
                    case ladder:
                        Console.WriteLine("Ladder, step up");
                        position += dice;
                        break;

                    case snake:
                        Console.WriteLine("Snake, step down");
                        position -= dice;
                        if (position < 0)
                            position = 0;
                        break;

                    default:
                        Console.WriteLine("You cannot move");
                        break;
                }
                Console.WriteLine("The player rolled a die " + dice + ",and now at position : " + position);
            }
        }
    }
}
