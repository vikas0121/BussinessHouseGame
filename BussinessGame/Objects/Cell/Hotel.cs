using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessGame.Objects.Cell
{
    class Hotel : Cell
    {
        public Hotel()
        {
            Name = "Hotel";
            Amount = 200;
            RewardType = Enums.RewardType.Credit;
        }
    }
}
