using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessGame.Objects.Board;

namespace BussinessGame.Objects
{
    class Player
    {
        public string Name { get; set; }
        public GameBoard GameBoard { get; set; }
        private int _moneyEarned = 1000;
        public int MoneyEarned
        {
            get
            {
                return this._moneyEarned;
            }
            //set
            //{
            //    this._moneyEarned = value;
            //}
        }

        public Player(string name, GameBoard gameBoard)
        {
            Name = name;
            GameBoard = gameBoard;
        }

        public Board.Cell RollDice()
        {
            var availablePanels = GameBoard.GetOpenRandomPanels();
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            var panelId = rand.Next(availablePanels.Count);
            return availablePanels[panelId];
        }

        internal void AddMoneyEarned(int p)
        {
            _moneyEarned += p;
        }
    }
}
