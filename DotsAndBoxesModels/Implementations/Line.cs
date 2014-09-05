namespace DotsAndBoxesModels.Implementations
{
    public class Line
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public int X1Coordinate { get; set; }
        public int Y1Coordinate { get; set; }
        public int[] XTypeCoordinates { get; set; }
        public int[] YTypeCoordinates { get; set; }
        public int[] AllCoordinates { get; set; }

        public Line(int x,int y, int x1,int y1)
        {
            XCoordinate = x;
            YCoordinate = y;
            X1Coordinate = x1;
            Y1Coordinate = y1;
            XTypeCoordinates = new[] {x, x1};
            YTypeCoordinates = new[] {y, y1};
            AllCoordinates = new[] {x, y, x1, y1};
        }

        public bool IsHorizontal()
        {
            return (XCoordinate == X1Coordinate);
        }

        public bool IsVertical()
        {
            return (YCoordinate == Y1Coordinate);
        }
    }
}