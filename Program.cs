namespace C_InnerFactory;

public class Point
{
    private double x, y;

    private Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // Creates new object every time it's called
    // public static Point Origin => new Point(0, 0);

    // Initiates object once and returns every time its called
    public static Point Origin = new Point(0, 0);

    public static class Factory
    {
        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }
    }

    public override string ToString()
    {
        return $"x: {x}, y: {y}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        var polarPoint = Point.Factory.NewPolarPoint(1.0, Math.PI / 2);
        System.Console.WriteLine(polarPoint);
        var cartesianPoint = Point.Factory.NewCartesianPoint(1.0, 2.0);
        System.Console.WriteLine(cartesianPoint);
    }
}
