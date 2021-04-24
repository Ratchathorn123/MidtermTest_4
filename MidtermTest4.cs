using System;

namespace MidtermTest_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float x1, x2, y1, y2, dx, dy, step;
            Console.WriteLine("Input floats x1, y1, x2, y2: ");
            X = float.Parse(Console.ReadLine());
            Y = float.Parse(Console.ReadLine());
            dX = x2 - x1;
            dy = y2 - y1;

            if (Math.Abs(dx) < Math.Abs(dy))
            {
                i = 1;
                dX = dx / step;
                dY = dy / step;
                X = x1;
                Y = y1;
                while (i <= step)
                {
                    x = x + dx;
                    y = y + dy;
                    i++;
                }
                Console.WriteLine("");
                if (i > step)
                {
                    Console.WriteLine("");
                }
            }
            else
            {
                i = 1;
                step = abs(dx);    
            }
        }
    }
}
