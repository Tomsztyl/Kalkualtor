using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkualtor
{
    public class GameBoard
    {
        public const int BOARD_SIZE = 3;
        public Cell[,] Board;
        //Constructor
        public GameBoard()
        {
            initializeBoard();
        }

        //Initialize Board - set board fields as empty

        private void initializeBoard()
        {
            Board = new Cell[BOARD_SIZE, BOARD_SIZE];
            for(int i =0;i<BOARD_SIZE;i++)
            {
                for(int j=0;j<BOARD_SIZE;j++)
                {
                    Board[i, j] = new Cell();
                }
            }
        }
        private void printBoard()
        {
            const int ASCII_CODE_0 = 48;
            int fieldNumber = 1;
            /*Add TextBox
             */
             for (int i=0;i<BOARD_SIZE;i++)
            {
                for (int j=0;j<BOARD_SIZE;j++)
                {
                    if (Board[i, j].isEmpty())
                    {
                        /*Add CW */
                        ;
                    }
                    else
                    {
                        /*Add CW*/
                        ;
                    }
                    fieldNumber++;

                    if ()
                }
            }
        }
    }
}
