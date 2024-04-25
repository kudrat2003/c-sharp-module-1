namespace CSharpModule.KichikShahzoda;

public struct Circle 
{
    public Point Centre{ get; set;}
    public int Radius{ get; set; }

    public Circle() : this (new Point(), 0) {}

    public Circle(Point centre, int radius) => (Centre, Radius) = (centre, radius);
    
    public readonly bool IsIn(Point point) => Centre.DistanceTo(point) < Radius;
    
}