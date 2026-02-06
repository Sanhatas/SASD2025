using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharp;

public class Point
{
    public double X { get; } //readonly property
    public double Y { get; } //readonly property
    public override string ToString() => $"({X}, {Y})";

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public static Point operator +(Point left, Point right) => new (left.X + right.X, left.Y + right.Y);

    //public double GetDistance()
    //{
    //    return Math.Sqrt(X * X + Y * Y);
    //}

    public double Distance => Math.Sqrt(X * X + Y * Y);
}
