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
            while (currentPosition <= 100)
            {
                Random random = new Random();
                int dieNumber = random.Next(1, 7);
                int option = random.Next(0, 3);
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
            Console.WriteLine(currentPosition);
        }
    }
}
