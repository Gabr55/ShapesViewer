using System.Windows;


namespace ShapesViewer;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void TriangleButton_Click(object sender, RoutedEventArgs e)
    {
        CustomShape triangle = new MyTriangle("Треугольник");
        CustomShape.Render(triangle, ShapeGrid);
    }

    private void SquareButton_Click(object sender, RoutedEventArgs e)
    {
        CustomShape square = new MySquare("Квадрат");
        CustomShape.Render(square, ShapeGrid);
    }

    private void RectangleButton_Click(object sender, RoutedEventArgs e)
    {
        CustomShape rectangle = new MyRectangle("Прямоугольник");
        CustomShape.Render(rectangle, ShapeGrid);
    }

    private void CircleButton_Click(object sender, RoutedEventArgs e)
    {
        CustomShape circle = new MyCircle("Круг");
        CustomShape.Render(circle, ShapeGrid);
    }
}