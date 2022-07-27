using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.App
{
    public class Cell
    {
        public Cell(Coordinate coordinate)
        {
            Coordinate = coordinate;
            Value = PlayerMarkerEnum.None;
        }

        public Coordinate Coordinate { get; }
        public PlayerMarkerEnum Value { get; set; }
    }
}
