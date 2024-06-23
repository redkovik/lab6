namespace Block1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;

      Point[] hexagonPoints = GetHexagonPoints(100, 100, 50);
      g.FillPolygon(Brushes.Red, hexagonPoints);
      g.DrawPolygon(Pens.Black, hexagonPoints);

      g.DrawEllipse(Pens.Black, 200, 50, 100, 50);

      g.DrawEllipse(Pens.Black, 350, 50, 50, 50);

      Point[] trianglePoints = { new Point(100, 200), new Point(50, 300), new Point(150, 300) };
      g.FillPolygon(Brushes.Green, trianglePoints);
      g.DrawPolygon(Pens.Black, trianglePoints);
    }

    private Point[] GetHexagonPoints(int xCenter, int yCenter, int size)
    {
      Point[] points = new Point[6];
      for (int i = 0; i < 6; i++)
      {
        points[i] = new Point(
            xCenter + (int)(size * Math.Cos(i * Math.PI / 3)),
            yCenter + (int)(size * Math.Sin(i * Math.PI / 3))
        );
      }
      return points;
    }
  }
}
