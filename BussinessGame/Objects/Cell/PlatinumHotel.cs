using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessGame.Objects.Cell
{
    class PlatinumHotel : Cell
    {
        public PlatinumHotel()
        {
            Name = "PlatinumHotel";
            Amount = 150;
            RewardType = Enums.RewardType.Credit;
        }
    }
}
