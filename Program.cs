using System;

namespace snakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCheck();
        }
        static void GameCheck()
        {
            const int startPoint = 0;
            int currentPosition = 0;
            int gameCount = 0;
            while (currentPosition <= 100)
            {
                gameCount++;
                Random random = new Random();
                int dieNumber = random.Next(1, 7);
                int option = random.Next(0, 3);
                Console.WriteLine(currentPosition);
                if ((currentPosition+dieNumber) > 100 && currentPosition != 100)
                {
                    continue;
                }
                switch (option)
                {
                    case 0:
                        break;
                    case 1:
                        currentPosition = currentPosition + dieNumber;
                        break;
                    case 2:
                        currentPosition = currentPosition - dieNumber;
                        break;
                }
                if (currentPosition <= 0)
                {
                    currentPosition = startPoint;
                }
            }
            Console.WriteLine("The number of times the dice was played to win the game is {0}",gameCount);
        }
    }
}
