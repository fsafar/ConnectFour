using System;

namespace ConnectFour.App
{
    public class Program
    {
        List<Cell> cells = new List<Cell>();

        int boardHeight = 6;
        int boardWidth = 8;

        Cell latestTurn = null;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // player one plays
            // latest turn is set to player one's last move
            // we check if this move was a horizontal win



        }

        public void MakeMove()
        {
            latestTurn = new Cell();
            latestTurn.Value = "G";

            var coordinate = new Coordinate();
            coordinate.X = 3;
            coordinate.Y = 2;

            latestTurn.Coordinate = coordinate;
        }
        public bool IsHorizontalWin()
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

                if (consecutiveCount == 4)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsVerticalWin()
        {
            return false;
        }

        public bool IsDiagonalWin()
        {
            return false;
        }
    }
    
    public class Cell
    {
        public Coordinate Coordinate { get; set; }
        public string Value { get; set; }
    }

    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}