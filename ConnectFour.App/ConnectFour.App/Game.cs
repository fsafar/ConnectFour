using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.App
{
    public class Game
    {
        List<Cell> cells = new List<Cell>();

        int boardHeight = 6;
        int boardWidth = 8;

        Cell latestTurn = null;

        public Game()
        {
            for (var row = 0; row < boardHeight; row++)
            {
                for (var column = 0; column < boardWidth; column++)
                {
                    var coordinate = new Coordinate(row, column);
                    var cell = new Cell(coordinate);
                    cells.Add(cell);
                }
            }
        }
    
        public void MakeMove(Coordinate coordinate, PlayerMarkerEnum playerMarker)
        {
            var cell = cells.Single(cell => cell.Coordinate.X == coordinate.X & cell.Coordinate.Y == coordinate.Y);
            cell.Value = playerMarker;

            latestTurn = cell;
        }

        public bool IsGameEnded()
        {
            if (latestTurn == null)
            {
                return false;
            }

            if (IsHorizontalWin())
            {
                return true;
            }


            return false;
        }

        private bool IsHorizontalWin()
        {
            var currentRowCells = cells
                .Where(cell => cell.Coordinate.X == latestTurn.Coordinate.X)
                .OrderBy(cell => cell.Coordinate.Y)
                .ToList();

            var consecutiveCount = 0;

            foreach (var cell in currentRowCells)
            {
                if (cell.Value == latestTurn.Value)
                {
                    consecutiveCount++;
                }
                else
                {
                    consecutiveCount = 0;
                }

                if (consecutiveCount == 4)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsVerticalWin()
        {
            throw new NotImplementedException();
        }

        private bool IsDiagonalWin()
        {
            throw new NotImplementedException();
        }
    }
}
