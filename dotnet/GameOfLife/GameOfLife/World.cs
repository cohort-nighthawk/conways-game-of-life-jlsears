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
        private int width = 50;

        public int Height { get; set; }
        public int Width { get; set; }

        public World()
        {
            this.Height = 50;
            this.Width = 50;
        }
    }
}
