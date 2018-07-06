using System;
using System.Collections.Generic;
using System.Linq;

namespace P09.RectangleIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var n = inputLine[0];
            var m = inputLine[1];
            List<Rectangle> myRectangles = new List<Rectangle>();

            for (int i = 0; i < n; i++)
            {
                var rectangleInfo = Console.ReadLine().Split(' ').ToArray();
                var id = rectangleInfo[0];
                var width = double.Parse(rectangleInfo[1]);
                var height = double.Parse(rectangleInfo[2]);
                var x = double.Parse(rectangleInfo[3]);
                var y = double.Parse(rectangleInfo[4]);
                Rectangle currRectangle = new Rectangle(id, width, height, x, y);
                myRectangles.Add(currRectangle);
            }

            for (int i = 0; i < m; i++)
            {
                var couples = Console.ReadLine().Split(' ').ToArray();
                var firstId = couples[0];
                var secId = couples[1];

                var firstRec = myRectangles.First(x => x.ID == firstId);
                var secRec = myRectangles.First(x => x.ID == secId);

                if (firstRec.Intersect(secRec))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
