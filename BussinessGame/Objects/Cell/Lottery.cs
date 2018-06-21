using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessGame.Objects.Cell
{
    class Lottery : Cell
    {
        public Lottery()
        {
            Name = "Lottery";
            Amount = 200;
            RewardType = Enums.RewardType.Credit;
        }
    }
}
