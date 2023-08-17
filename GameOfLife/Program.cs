using System;
using System.Threading;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {

            GOL gol = new GOL(50, 50);
            Random rand = new Random();
            for (int y = 0; y < gol.Height; y++)
            {
                for (int x = 0; x < gol.Width; x++)
                {
                    gol.SetCell(x, y, rand.NextDouble() >= 0.5);
                }
            }

            while (true)
            {
                gol.Update();
                gol.Draw();
                Thread.Sleep(200);
            }

        }
    }
}
