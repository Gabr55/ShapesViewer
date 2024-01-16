using System.Windows.Media;
using System.Windows.Shapes;

namespace ShapesViewer;

internal class MySquare : CustomShape
{
    public MySquare(string label) : base(label) { }

    public override Shape GetShape()
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Width = 200;
        rectangle.Height = 200;
        rectangle.Stroke = Brushes.Black;
        rectangle.StrokeThickness = 4;
        return rectangle;
    }
}
