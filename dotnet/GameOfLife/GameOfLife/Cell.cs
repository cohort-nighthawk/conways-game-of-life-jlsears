using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Cell
    {
        private bool living;

        public bool Living { get; set; }  

        public Cell()
        {
            this.Living = true;
        }
    }
}
