using System;

namespace NoOfTimesDieRolled
{
    class Program
    {
        //constatnts
        public const int ladder = 1;
        public const int snake = 2;
        static void Main(string[] args)
        {
            int position = 0;
            int rollcount = 0;
            //Loop for player position reaches 100
            while (position < 100)
            {
                rollcount++;
                Random random = new Random();
                int dice = random.Next(1, 7);
                int option = random.Next(0, 3);
                //Player next position - Move forward, move backward, no moves
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
                //Not to exceed position 100, player rolls die to get exact position of 100
                if (position > 100)
                {
                    position -= dice;
                    Console.WriteLine("Cannot move, roll again");
                }
                Console.WriteLine("The player rolled a die " + dice + ",and now at position : " + position);
            }
            Console.WriteLine("The total no of time die was rolled to win is :" + rollcount);
        }
    }
}
