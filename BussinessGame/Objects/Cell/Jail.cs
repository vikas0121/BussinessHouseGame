using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessGame.Objects.Cell
{
    class Jail : Cell
    {
        public Jail()
        {
            Name = "Jail";
            Amount = -150;
            RewardType = Enums.RewardType.Debit;
        }
    }
}
