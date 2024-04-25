namespace CSharpModule.KichikShahzoda;

public struct Point
{
    public int X{ get; set; }
    public int Y{ get; set; }

    public Point() : this(0, 0) { }

    public Point(int x, int y) => (X, Y)=(x, y);

    public readonly double DistanceTo(Point other)
    {
        var a = X - other.X;
        var b = Y - other.Y;

        var c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));

        return c;
    }
}

