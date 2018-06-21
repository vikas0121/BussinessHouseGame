using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessGame.Objects.Board
{
    public class Panel
    {
        public Enums.CellType CellType { get; set; }
        public Cell Coordinates { get; set; }

        public Panel(int row, int column)
        {
            Coordinates = new Cell(row, column);
            //OccupationType = OccupationType.Empty;
        }

        public bool IsRandomAvailable
        {
            get { return true; }
        }
    }
}
