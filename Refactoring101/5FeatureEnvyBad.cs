using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101.FeatureEnvyBad;

// 5
public class FeatureEnvy
{
    public void TestAdd()
    {
        // First Idea
        //var point = Point.Add(new Point(2, 3), new Point(4, 5));

        // Second Idea
        //var point = new Point(2, 3).Add(new Point(4, 5));

        // Third Idea
        var point = new Point(2, 3) + new Point(4, 5);
    }
}

public class Point
{
    public double X { get; }
    public double Y { get; }
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    // First Idea
    //public static Point Add(Point a, Point b)
    //{
    //    return new Point(a.X + b.X, a.Y + b.Y);
    //}


    // Second Idea
    // a.Add(b);
    //public static Point Add(Point b)
    //{
    //    return new Point(this.X + b.X, this.Y + b.Y);
    //}

    // Third Idea
    public static Point operator +(Point a, Point b)
    {
        return new Point(a.X + b.X, a.Y + b.Y);
    }
}
