using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessGame.Objects.Cell;

namespace BussinessGame
{
    class CellFactory
    {
        public virtual Cell CreateCell(Enums.CellType method)
        {
            Cell cellType = null;

            switch (method)
            {
                case Enums.CellType.Hotel:
                    cellType = new Hotel();
                    break;
                case Enums.CellType.Jail:
                    cellType = new Jail();
                    break;
                case Enums.CellType.Lottery:
                    cellType = new Lottery();
                    break;
                case Enums.CellType.GoldHotel:
                    cellType = new GoldHotel();
                    break;
                case Enums.CellType.PlatinumHotel:
                    cellType = new PlatinumHotel();
                    break;
                default:
                    break;
            }
            return cellType;
        }
    }
}
