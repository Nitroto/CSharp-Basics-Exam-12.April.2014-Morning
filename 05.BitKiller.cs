using System;
using System.Globalization;
using System.Threading;

class BitKiller
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        int index = 0;
        int position = 7;
        int result = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            for (int bit = 7; bit >= 0; bit--)
            {
                if (!((index % s == 1) || (s == 1 && index > 0)))
                {
                    int extractedBit = (num >> bit) & 1;
                    result |= (extractedBit << position);
                    position--;
                    if (position < 0)
                    {
                        Console.WriteLine(result);
                        result = 0;
                        position = 7;
                    }
                }
                index++;
            }
        }
        if (position < 7)
        {
            Console.WriteLine(result);
        }
    }
}

