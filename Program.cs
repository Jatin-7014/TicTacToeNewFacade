using TicTacToeFacadeDp.Exceptions;

namespace TicTacToeFacadeDp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
 
            board.SetCellMark(0, MarkType.O); 

            board.SetCellMark(1, MarkType.X); 

            board.SetCellMark(4, MarkType.O); 

            board.SetCellMark(3, MarkType.X); 

            board.SetCellMark(8, MarkType.O); 


            ResultAnalyzer analyzer = new ResultAnalyzer(board);

            ResultType result = analyzer.AnalyzeResult();

            switch (result)
            {
                case ResultType.WIN:
                    Console.WriteLine("Player O Wins!");
                    break;
                case ResultType.LOOSE:
                    Console.WriteLine("Player X Wins!");
                    break;
                case ResultType.DRAW:
                    Console.WriteLine("It's a Draw!");
                    break;
                case ResultType.PROGRESS:
                    Console.WriteLine("Game is still in progress.");
                    break;
            }
        }
    }
}
