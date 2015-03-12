using System;
using System.Globalization;
using System.Threading;

class House
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int halfN = n / 2;
        int spacesBefore = halfN;
        int middleSpaces = 1;
        Console.Write(new string('.', spacesBefore));
        Console.Write(new string('*', 1));
        Console.Write(new string('.', spacesBefore));
        Console.WriteLine();
        spacesBefore--;
        for (int i = 0; i < halfN - 1; i++)
        {
            Console.Write(new string('.', spacesBefore));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', middleSpaces));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', spacesBefore));
            spacesBefore--;
            middleSpaces += 2;
            Console.WriteLine();
        }
        Console.Write(new string('*', n));
        Console.WriteLine();
        spacesBefore = n / 4;
        middleSpaces = n - 2 - 2 * spacesBefore;
        for (int i = 0; i < halfN - 1; i++)
        {
            Console.Write(new string('.', spacesBefore));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', middleSpaces));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', spacesBefore));
            Console.WriteLine();
        }
        Console.Write(new string('.', spacesBefore));
        Console.Write(new string('*', middleSpaces + 2));
        Console.WriteLine(new string('.', spacesBefore));
    }
}
