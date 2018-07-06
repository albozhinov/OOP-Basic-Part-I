using System;
using System.Globalization;
using System.Linq;

public class DateMod
{
    public static void CalculateDays(string date1, string date2)
    {
        var d1 = date1.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        var d2 = date2.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        var firstDate = new DateTime(d1[0], d1[1], d1[2]);
        var secDate = new DateTime(d2[0], d2[1], d2[2]);

        var diff  = firstDate.Subtract(secDate);       

        Console.WriteLine($"{Math.Abs(diff.Days)}");
    }


}



