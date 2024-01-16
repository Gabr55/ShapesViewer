using System.Windows.Controls;
using System.Windows.Shapes;

namespace ShapesViewer;

/// <summary>
/// Abstract Shape class
/// </summary>
internal abstract class CustomShape
{
    public CustomShape(string? label = "")
    {
        TextBlock text = new();
        text.Text = label;
        text.FontSize = 22;
        Label = text;
    }
    public TextBlock Label { get; set; }

    public virtual Shape GetShape()
    {
        return new Polygon();
    }

    public static void Render(CustomShape shape, Grid grid)
    {
        grid.Children.Clear();
        grid.Children.Add(shape.GetShape());
        grid.Children.Add(shape.Label);
    }
}
