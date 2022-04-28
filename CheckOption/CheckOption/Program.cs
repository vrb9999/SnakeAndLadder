using System;

namespace CheckOption
{
    class Program
    {
        public const int ladder = 1;
        public const int snake = 2;
        static void Main(string[] args)
        {
            int position = 0;
            Random random = new Random();
            int dice = random.Next(1, 7);
            int option = random.Next(0, 3);
            Console.WriteLine("Option is : " + option);
            switch (option)
            {
                case ladder:
                    position += dice;
                    break;

                case snake:
                    position -= dice;
                    if (position < 0)
                        position = 0;
                    break;

                default: break;
            }
            Console.WriteLine("The player rolled a die  " + dice + ",and now at position : " + position);
        }
    }
}
