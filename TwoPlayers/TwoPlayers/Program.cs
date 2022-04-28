using System;

namespace TwoPlayers
{
    class Program
    {
        public const int ladder = 1;
        public const int snake = 2;
        public const int player1 = 1;
        public const int player2 = 2;
        static void Main(string[] args)
        {
            int player = 1;
            int PositionOfPlayer1 = 0;
            int PositionOfPlayer2 = 0;
            int rollcount = 0;
            while (PositionOfPlayer1 < 100 && PositionOfPlayer2 < 100)
            {
                rollcount++;
                Random random = new Random();
                int dice = random.Next(1, 7);
                int option = random.Next(0, 3);
                switch (option)
                {
                    case ladder:
                        Console.WriteLine("The player {player} rolled a die " + dice);
                        Console.WriteLine("Yeah! Player{player}, its a ladder,you are moving ahead");
                        if (player == player1)
                            PositionOfPlayer1 += dice;
                        else
                            PositionOfPlayer2 += dice;
                        break;

                    case snake:
                        Console.WriteLine("The player {player} rolled a die " + dice);
                        Console.WriteLine("Opss! Player{player}, its a snake,you are going down");

                        if (player == player2)
                        {
                            PositionOfPlayer2 -= dice;
                            if (PositionOfPlayer2 < 0)
                                PositionOfPlayer2 = 0;
                        }
                        else
                        {
                            PositionOfPlayer1 -= dice;
                            if (PositionOfPlayer1 < 0)
                                PositionOfPlayer1 = 0;
                        }
                        break;

                    default:
                        Console.WriteLine("Player {player},You cannot move");
                        break;
                }
                if (PositionOfPlayer1 > 100 || PositionOfPlayer2 > 100)
                {

                    Console.WriteLine("Player {player}Cannot move ...rolling again");
                    if (player == player1)
                        PositionOfPlayer1 -= dice;
                    else
                        PositionOfPlayer2 -= dice;


                }
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Player 1 is at position : \t" + PositionOfPlayer1);
                Console.WriteLine("Player 2 is at position : \t" + PositionOfPlayer2);


                if (option == ladder)
                {
                    Console.WriteLine("Congrats! its an ladder, Player{player}, got one more Chance to roll the die");
                }
                else if (player == player1)
                {
                    Console.WriteLine("Second Player turn");
                    player = 2;
                }
                else
                {
                    Console.WriteLine("First Player Turn");
                    player = 1;
                }
            }
            Console.WriteLine("The total no of time die was rolled to win is :" + rollcount);
            if (PositionOfPlayer1 == 100)
            {
                Console.WriteLine("Player1 Wins");
            }
            else
            {
                Console.WriteLine("Player2 Wins");
            }
        }
    }
}
