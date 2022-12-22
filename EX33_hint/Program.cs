using System;

namespace EX33_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            RectAngle rectAngle1 = new RectAngle(25, 12);
            RectAngle rectAngle2 = new RectAngle(35, 48);            
            if (rectAngle1 == rectAngle2)
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しい");
            }
            else
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しくない");
            }
            RectAngle rectangle3 = rectAngle1 + rectAngle2;
            Console.WriteLine($"2つの長方形が入る最小の長方形は({rectangle3.width},{rectangle3.height})");
        }
    }
}
