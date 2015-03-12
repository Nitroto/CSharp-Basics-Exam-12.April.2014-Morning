using System;
using System.Globalization;
using System.Threading;

namespace Triangle
{
    class Triangle
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int aX = int.Parse(Console.ReadLine());
            int aY = int.Parse(Console.ReadLine());
            int bX = int.Parse(Console.ReadLine());
            int bY = int.Parse(Console.ReadLine());
            int cX = int.Parse(Console.ReadLine());
            int cY = int.Parse(Console.ReadLine());
            double cathetus1 = Math.Sqrt(((bX - aX) * (bX - aX)) + ((bY - aY) * (bY - aY)));
            double cathetus2 = Math.Sqrt(((cX - bX) * (cX - bX)) + ((cY - bY) * (cY - bY)));
            double hypotenuse = Math.Sqrt(((aX - cX) * (aX - cX)) + ((aY - cY) * (aY - cY)));
            bool canFormTriangle = ((cathetus1 + cathetus2) > hypotenuse && (cathetus1 + hypotenuse) > cathetus2 && (cathetus2 + hypotenuse) > cathetus1);
            if (canFormTriangle)
            {
                Console.WriteLine("Yes");
                double halfP = (cathetus1 + cathetus2 + hypotenuse) / 2.0;
                double area = Math.Sqrt((halfP * (halfP - cathetus1) * (halfP - cathetus2) * (halfP - hypotenuse)));
                Console.WriteLine("{0:F2}", area);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:F2}", cathetus1);
            }
        }
    }
}
