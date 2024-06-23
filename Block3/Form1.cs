using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Block3
{
  public partial class Form1 : Form
  {
    private System.Windows.Forms.Timer timer1;
    private float angle;
    private const int rectWidth = 100;
    private const int rectHeight = 50;

    private const int rectX = 350; // (800 - 100) / 2
    private const int rectY = 205; // (600 - 50) / 2

    public Form1()
    {
      InitializeComponent();
      this.DoubleBuffered = true;

      timer1 = new System.Windows.Forms.Timer();
      timer1.Interval = 25; // Інтервал оновлення в мілісекундах
      timer1.Tick += new EventHandler(timer1_Tick);
      timer1.Start();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      angle += 5;
      if (angle >= 360)
      {
        angle = 0;
      }
      Invalidate();
    }
    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      Graphics g = e.Graphics;

      Matrix matrix = new Matrix();
      matrix.RotateAt(angle, new PointF(rectX, rectY));

      g.Transform = matrix;

      g.FillRectangle(Brushes.Blue, rectX, rectY, rectWidth, rectHeight);
    }
  }
}
