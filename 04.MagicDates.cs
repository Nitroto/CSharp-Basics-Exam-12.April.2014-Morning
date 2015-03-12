using System;
using System.Globalization;
using System.Threading;

class MagicDates
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int weight = int.Parse(Console.ReadLine());
        int magicDate = 0;
        for (int year = startYear; year <= endYear; year++)
        {
            for (int month = 1; month <= 12; month++)
            {
                for (int day = 1; day <= 31; day++)
                {
                    int d1 = day / 10;
                    int d2 = day % 10;
                    int m1 = month / 10;
                    int m2 = month % 10;
                    int y1 = year / 1000;
                    int y2 = year / 100 % 10;
                    int y3 = year / 10 % 10;
                    int y4 = year % 10;
                    int dateWeight = (d1 * d2 + d1 * m1 + d1 * m2 + d1 * y1 + d1 * y2 + d1 * y3 + d1 * y4) + (d2 * m1 + d2 * m2 + d2 * y1 + d2 * y2 + d2 * y3 + d2 * y4) +
                        (m1 * m2 + m1 * y1 + m1 * y2 + m1 * y3 + m1 * y4) + (m2 * y1 + m2 * y2 + m2 * y3 + m2 * y4) + (y1 * y2 + y1 * y3 + y1 * y4) + (y2 * y3 + y2 * y4) + (y3 * y4);
                    string date = month + "/" + day + "/" + year;
                    DateTime checkedDate;
                    bool isRealDate = DateTime.TryParse(date, out checkedDate);
                    if (isRealDate && weight == dateWeight)
                    {
                        magicDate++;
                        Console.WriteLine(checkedDate.ToString("dd-MM-yyyy"));
                    }
                }
            }
        }
        if (magicDate == 0)
        {
            Console.WriteLine("No");
        }
    }
}