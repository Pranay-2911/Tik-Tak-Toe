using Tik_Tak_Toe.Models;

namespace Tik_Tak_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            Player player1 = new Player(Type.MarkType.X);
            Player player2 = new Player(Type.MarkType.O);

            Game game = new Game();
             
            ResultAnalyser resultAnalyser = new ResultAnalyser();

            
            game.StartGame(player1 , player2, board, resultAnalyser);
            
        }
    }
}
