using System;
using System.Collections.Generic;

namespace FloydsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            createFloyds(10);
        }

        // function that writes a floyds triangle of height [height] to the console
        static void createFloyds(int height)
        {
            int curr = 1;

            for (int row = 1; row <= height; row++)
            {
                List<int> numLine = new List<int>();
                for (int col = 0; col < row; col++)
                {
                    numLine.Add(curr);
                    curr++;
                }
                Console.WriteLine(string.Join(", ", numLine));
            }
        }
    }
}
