using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeFacadeDp
{
    internal class ResultAnalyzer
    {
        Board _board;
        ResultType _result;

        public ResultAnalyzer(Board board)
        {
            _board = board;
            _result=ResultType.PROGRESS;
        }
        private void HorizontalWinCheck() 
        {
            if (_board.GetCellMark(0) == _board.GetCellMark(1) && _board.GetCellMark(1) == _board.GetCellMark(2))
                _result = ResultType.WIN;
            else if (_board.GetCellMark(3) == _board.GetCellMark(4) && _board.GetCellMark(4) == _board.GetCellMark(5))
                _result = ResultType.WIN;
            else if (_board.GetCellMark(6) == _board.GetCellMark(7) && _board.GetCellMark(7) == _board.GetCellMark(8))
                _result = ResultType.WIN;
        }
        private void VerticalWinCheck()
        {
            if (_board.GetCellMark(0) == _board.GetCellMark(3) && _board.GetCellMark(3) == _board.GetCellMark(6))
                _result = ResultType.WIN;
            else if (_board.GetCellMark(1) == _board.GetCellMark(4) && _board.GetCellMark(4) == _board.GetCellMark(7))
                _result = ResultType.WIN;
            else if (_board.GetCellMark(2) == _board.GetCellMark(5) && _board.GetCellMark(5) == _board.GetCellMark(8))
                _result = ResultType.WIN;
        }
        private void DiagonalWinCheck()
        {
            if (_board.GetCellMark(0) == _board.GetCellMark(4) && _board.GetCellMark(4) == _board.GetCellMark(8))
                _result = ResultType.WIN;
            else if (_board.GetCellMark(2) == _board.GetCellMark(4) && _board.GetCellMark(4) == _board.GetCellMark(6))
                _result = ResultType.WIN;
            
        }
        public ResultType AnalyzeResult()
        {
            HorizontalWinCheck();
            VerticalWinCheck();
            DiagonalWinCheck();
            if (_result == ResultType.WIN)
                return _result;
            else if(_board.IsBoardFull())
                return ResultType.DRAW;
            else return _result;
        }
    }
}
