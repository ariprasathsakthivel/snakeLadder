using System;

namespace snakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentPosition1 = 0; //Position of Player1
            int currentPosition2 = 0; //Position of Player2
            int gameCount = 0;
            while (currentPosition1 < 100 && currentPosition2 <100)
            {
                gameCount++;
                Console.WriteLine("The number of times the dice was played to win the game is {0}", gameCount);
                currentPosition1 = GameCheck(currentPosition1);
                Console.WriteLine("currentPosition of player1--> {0}", currentPosition1);
                currentPosition2 = GameCheck(currentPosition2);
                Console.WriteLine("currentPosition of player2--> {0}", currentPosition2);
            }
            if (currentPosition1 == 100 && currentPosition2 < 100)
            {
                Console.WriteLine("Player1 is the winner");
                Console.WriteLine("Player2 lost the game");
            }
            else if (currentPosition1 == 100 && currentPosition2 == 100)
            {
                Console.WriteLine("The game is a tie");
            }
            else
            {
                Console.WriteLine("Player2 is the winner");
                Console.WriteLine("Player1 lost the game");
            }
        }
        static int GameCheck(int currentPosition)
        {
            const int startPoint = 0;
            Random random = new Random();
            int dieNumber = random.Next(1, 7); 
            int option = random.Next(0, 3); 
            if ((currentPosition + dieNumber) > 100)
            {
            }
            else
            {
            switch (option)
            {
                case 0: //No play
                    break;
                case 1:  //Ladder
                    currentPosition = currentPosition + dieNumber;
                    break;
                case 2:  //Snake
                    currentPosition = currentPosition - dieNumber;
                    break;
            }
            }
            if (currentPosition <= 0)
            {
                currentPosition = startPoint;
            }
            return currentPosition;
        }
    }
}
