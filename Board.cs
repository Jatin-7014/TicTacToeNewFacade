using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeFacadeDp.Exceptions;

namespace TicTacToeFacadeDp
{
    internal class Board
    {
        Cell[] cell=new Cell[9];
        public Board()
        {
            for(int i=0;i<cell.Length;i++)
            {
                cell[i] = new Cell();
            }
        }
        public bool IsBoardFull()
        {
            foreach(var pos in cell)
            {
                if(pos.IsEmpty())
                    return false;
            }
            return true;
        }
        public void SetCellMark(int loc,MarkType mark)
        {
            if (cell[loc].IsEmpty())
            {
                cell[loc].SetMark(mark);
                DisplayBoard();
            }
            else
            throw new CellAlreadyMarkedException("This cell is already marked....");

        }
        public MarkType GetCellMark(int loc)
        {
            return cell[loc].GetMark();
        }
        public void DisplayBoard()
        {
            
            Console.WriteLine($"=========After Turn=============");
            for (int i = 0; i < 9; i++)
            {
                string mark = cell[i].GetMark() == MarkType.EMPTY ? " " : cell[i].GetMark().ToString();
                Console.Write($" {mark} ");

                if (i % 3 != 2) Console.Write("|");

                if (i % 3 == 2 && i < 8)
                {
                    Console.WriteLine();
                    Console.WriteLine("---+---+---");
                }
            }
            
            Console.WriteLine();
        }
    }
}
