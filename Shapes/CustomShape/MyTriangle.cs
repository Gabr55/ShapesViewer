using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;


namespace ShapesViewer;

internal class MyTriangle : CustomShape
{
    public MyTriangle(string label) : base(label) { }

    public override Polygon GetShape()
    {
        double radius = 100;
        int numSides = 3;
        Point center = new Point(300, 120);

        Polygon polygon = new Polygon();
        polygon.Stroke = Brushes.Black;
        polygon.StrokeThickness = 4;

        for (int i = 0; i < numSides; i++)
        {
            double angle = Math.PI * 2 * i / numSides;
            double x = center.X + radius * Math.Cos(angle);
            double y = center.Y + radius * Math.Sin(angle);
            polygon.Points.Add(new Point(x, y));
        }

        return polygon;
    }
}
