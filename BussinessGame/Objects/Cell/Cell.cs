using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessGame.Objects.Cell
{
    public abstract class Cell
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public int Type { get; set; }
        public Enums.RewardType RewardType { get; set; }

    }
}
