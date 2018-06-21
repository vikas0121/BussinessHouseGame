using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessGame
{
    public class Enums
    {
        public enum CellType
        {
            Empty,
            Jail,
            Lottery,
            Hotel,
            GoldHotel,
            PlatinumHotel
        }

        public enum RewardType
        {
            Credit,
            Debit
        }    
    }
}
