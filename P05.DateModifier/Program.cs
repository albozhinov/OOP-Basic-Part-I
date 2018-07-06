using System;
using System.Globalization;

namespace P05.DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine();
            var secInput = Console.ReadLine();

            DateMod.CalculateDays(firstInput, secInput);
        }
    }
}
