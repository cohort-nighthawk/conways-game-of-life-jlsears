using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class World
    {
        string[] row1 = new string[4] { "1,1", "1,2", "1,3", "1,4" };
        string[] row2 = new string[4] { "2,1", "2,2", "2,3", "2,4" };
        string[] row3 = new string[4] { "3,1", "3,2", "3,3", "3,4" };
        string[] row4 = new string[4] { "4,1", "4,2", "4,3", "4,4" };

        // Need to figure out what's amiss here when more awake
        string[,] aWorld = new string[16] { row1[0], row1[1], row1[2], row1[3], row2[0], row2[1], row2[2], row2[3], row3[0], row3[1], row3[2], row3[3], row4[0], row4[1], row4[2], row4[3] };
    }

}
