using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soduku
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardText =
                "4 . . . . . 8 . 5" +
                ". 3 . . . . . . ." +
                ". . 7 . . . . . ." +
                ". 2 . . . . . 6 ." +
                ". . . 8 . 4 . . ." +
                ". . . 1 . . . . ." +
                ". . . 6 . 3 . 7 ." +
                "5 . . 2 . . . . ." +
                "1 . 4 . . . . . .";
            
            var board = new Board();
            board.ReadBoard(boardText);
            

        }

        static void Run()
        {
           //While All Cells Have more than One Possibility
            //Go to next row 
                //Go to next cell in column
                  //if Cell Possibility > 1
                    //Check Square Remove Possibilties 
                    // Check row Remove Possibilities
                    // Check column Remove Possibilities
             
           
            
        }
    }

    
}
