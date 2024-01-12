using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public struct ShelvePosition
    {
        public ShelvePosition(int row, int col)
        {
            Row = row;
            Col = col; 

        }
        public int Row { get; set; }
        public int Col { get; set; }  
    }
}
