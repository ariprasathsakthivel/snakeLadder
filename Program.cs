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
            int startPoint = 0;
            Random random = new Random();
            int dieNumber = random.Next(1, 7);
            Console.WriteLine("Die number is : {0}",dieNumber);
        }
    }
}
