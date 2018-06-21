using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessGame.Objects.Board;

namespace BussinessGame.Extensions
{
    public static class PanelExtension
    {
        public static Panel At(this List<Panel> panels, int row, int column)
        {
            return panels.First(x => x.Coordinates.Row == row && x.Coordinates.Column == column);
        }
    }
}
