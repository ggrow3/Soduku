using System.Collections.Generic;
using System.Linq;

namespace Soduku
{
    public class Cell
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public List<int> PossibleValues { get; set; }

        public Cell(int col, int row)
        {
            Col = col;
            Row = row;
            PossibleValues = Enumerable.Range(1, 9).ToList();
        }

        
    }
}