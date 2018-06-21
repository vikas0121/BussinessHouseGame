using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessGame.Objects.Cell
{
    class GoldHotel : Cell
    {
        public GoldHotel()
        {
            Name = "GoldHotel";
            Amount = 150;
            RewardType = Enums.RewardType.Credit;
        }
    }
}
