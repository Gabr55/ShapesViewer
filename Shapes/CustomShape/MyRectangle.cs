﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShapesViewer;

internal class MyRectangle : CustomShape
{
    public MyRectangle(string label) : base(label) { }

    public override Shape GetShape()
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Width = 250;
        rectangle.Height = 150;
        rectangle.Stroke = Brushes.Black;
        rectangle.StrokeThickness = 4;
        return rectangle;
    }
}
