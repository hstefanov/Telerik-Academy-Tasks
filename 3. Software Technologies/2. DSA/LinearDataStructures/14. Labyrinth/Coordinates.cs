namespace Labyrinth
{
    public struct Coordinates
    {
        public int Row { get; private set; }

        public int Col { get; private set; }

        public Coordinates(int row, int col)
            : this()
        {
            this.Row = row;
            this.Col = col;
        }

        public static Coordinates operator +(Coordinates a, Coordinates b)
        {
            return new Coordinates(
                a.Row + b.Row,
                a.Col + b.Col
            );
        }

        public static Coordinates operator -(Coordinates a, Coordinates b)
        {
            return new Coordinates(
                a.Row - b.Row,
                a.Col - b.Col
            );
        }
    }
}
