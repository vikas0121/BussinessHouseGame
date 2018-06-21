using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessGame.Extensions;
using BussinessGame.Objects.Board;

namespace BussinessGame.Objects.Game
{
    class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public GameBoard GameBoard { get; set; }
        private int _chances;
        private Bank Bank = Bank.Instance;
        public Enums.CellType CurrentStatus { get; set; }

        public Game(int chances)
        {
            GameBoard = new GameBoard();
            this._chances = chances;
            Player1 = new Player("Vikas", GameBoard);
            Player2 = new Player("Vijay", GameBoard);

        }

        public void PlayToEnd()
        {
            while (_chances >= 10)
            {
                PlayRound();
                _chances -= 1;
            }

            if (Player1.MoneyEarned > Player2.MoneyEarned)
                Console.WriteLine(Player1.Name + " has won the game!");
            else
                Console.WriteLine(Player2.Name + " has won the game!");
        }

        private void PlayRound()
        {
            var coords = Player1.RollDice();
            GetResult(coords, Player1);
            var coord2 = Player2.RollDice();
            GetResult(coord2, Player2);
        }

        private void GetResult(Board.Cell coords, Player player)
        {
            var panel = GameBoard.Panels.At(coords.Row, coords.Column);
            CellFactory objCellFactory = new CellFactory();
            var result = objCellFactory.CreateCell(panel.CellType);
            if (result != null)
            {

                player.AddMoneyEarned(result.Amount);
                Bank.AddMoneyEarned(result.Amount);
            }
        }
    }
}
