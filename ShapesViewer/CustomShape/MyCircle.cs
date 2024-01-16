using System.Windows.Media;
using System.Windows.Shapes;

namespace ShapesViewer;

internal class MyCircle : CustomShape
{
    public MyCircle(string label) : base(label) { }

    public override Shape GetShape()
    {
        Ellipse circle = new Ellipse();
        circle.Width = 200;
        circle.Height = 200;
        circle.Stroke = Brushes.Black;
        circle.StrokeThickness = 4;
        return circle;
    }
}
