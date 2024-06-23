using System;
using System.Drawing;
using System.Windows.Forms;

namespace Block2
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
      Pen pen = new Pen(Color.Black, 2);
      Brush brush = new SolidBrush(Color.Green);

      g.FillRectangle(brush, 50, 100, 200, 50);
      g.DrawRectangle(pen, 50, 100, 200, 50);

      g.FillRectangle(brush, 175, 80, 50, 10);
      g.DrawRectangle(pen, 175, 80, 50, 10);

      g.FillRectangle(brush, 120, 70, 60, 40);
      g.DrawRectangle(pen, 120, 70, 60, 40);

      for (int i = 0; i < 5; i++)
      {
        int x = 60 + i * 40;
        g.FillEllipse(brush, x, 150, 30, 30);
        g.DrawEllipse(pen, x, 150, 30, 30);
      }

      g.DrawLine(pen, 50, 180, 250, 180);
      g.DrawLine(pen, 50, 150, 250, 150);
    }
  }
}
