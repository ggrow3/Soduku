using System;
using System.Collections.Generic;

namespace Soduku
{
    internal class Board
    {
        public List<Cell> Cells { get; set; }

        public Board()
        {
            Cells = new List<Cell>();
            int rowNum = 9;
            int colNum = 9;
            for (int r = 0;r < rowNum; r++)
            {
                for (int c = 0; c < colNum; c++)
                {
                    Cells.Add(new Cell(col: c, row: r));
                }
            }
        }

        internal void ReadBoard(string boardText)
        {
            throw new NotImplementedException();
        }
    }
}