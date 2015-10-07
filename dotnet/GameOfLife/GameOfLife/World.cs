using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class World
    {
        public static void createWorld()
        {
            // Need to figure out what's amiss here when more awake
            string[][] aWorld = new string[4][];

            aWorld[0] = new string[4] { "1,1", "1,2", "1,3", "1,4" };
            aWorld[1] = new string[4] { "2,1", "2,2", "2,3", "2,4" };
            aWorld[2] = new string[4] { "3,1", "3,2", "3,3", "3,4" };
            aWorld[3] = new string[4] { "4,1", "4,2", "4,3", "4,4" };

            //for (int i = 0; i < aWorld.Length; i++)
            //{
            //    System.Console.Write("Element({0}): ", i);

            //    for (int j = 0; j < aWorld[i].Length; j++)
            //    {
            //        System.Console.Write("{0}{1}", aWorld[i][j], j == (aWorld[i].Length - 1) ? "" : " ");
            //    }
            //    System.Console.WriteLine();
            //    System.Console.ReadLine();
            //}
        }
    }
}
