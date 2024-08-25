using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeFacadeDp.Exceptions;

namespace TicTacToeFacadeDp
{
    internal class Cell
    {
        MarkType _mark {  get; set; }
        public Cell()
        {
            _mark=MarkType.EMPTY;
        }
        public bool IsEmpty()
        {
            if(_mark==MarkType.EMPTY)
                return true;
            return false;
        }
        public MarkType GetMark()
        {
            return _mark;
        }
        public void SetMark(MarkType mark)
        {
            if (_mark != MarkType.EMPTY)
                throw new CellAlreadyMarkedException("This cell is already marked...");
            _mark = mark;
        }
    }
}
