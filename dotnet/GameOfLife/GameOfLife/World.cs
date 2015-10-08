using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class World
    {
        private int height = 50;

        public int Height { get; set; }

        public World()
        {
            this.Height = 50;
        }
    }
}
