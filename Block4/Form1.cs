using System;
using System.Drawing;
using System.Windows.Forms;

namespace Block4
{
  public partial class Form1 : Form
  {
    private System.Windows.Forms.Timer timer1;
    private int periscopeY;
    private bool isRising;
    private const int periscopeWidth = 20;
    private const int periscopeHeight = 100;
    private const int submarineWidth = 200;
    private const int submarineHeight = 50;
    private const int minPeriscopeY = 175;
    private const int maxPeriscopeY = 250;

    public Form1()
    {
      InitializeComponent();
      this.DoubleBuffered = true;

      // Ініціалізація початкової позиції перископа
      periscopeY = maxPeriscopeY;
      isRising = true;

      // Ініціалізація таймера
      timer1 = new System.Windows.Forms.Timer();
      timer1.Interval = 50; // Інтервал оновлення в мілісекундах
      timer1.Tick += new EventHandler(timer1_Tick);
      timer1.Start();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      // Зміна позиції перископа
      if (isRising)
      {
        periscopeY -= 2;
        if (periscopeY <= minPeriscopeY)
        {
          isRising = false;
        }
      }
      else
      {
        periscopeY += 2;
        if (periscopeY >= maxPeriscopeY)
        {
          isRising = true;
        }
      }

      Invalidate(); // Виклик перерисовки форми
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      Graphics g = e.Graphics;
      int submarineX = (this.ClientSize.Width - submarineWidth) / 2;
      int submarineY = (this.ClientSize.Height - submarineHeight) / 2;
      // Малювання перископа
      int periscopeX = submarineX + submarineWidth / 2 - periscopeWidth / 2;
      g.FillRectangle(Brushes.Black, periscopeX, periscopeY, periscopeWidth, periscopeHeight);
      // Малювання моря
      int seaHeight = this.ClientSize.Height - submarineY - submarineHeight;
      g.FillRectangle(Brushes.Blue, 0, submarineY + submarineHeight, this.ClientSize.Width, seaHeight);


      // Малювання підводного човна

      g.FillRectangle(Brushes.Gray, submarineX, submarineY, submarineWidth, submarineHeight);


    }
  }
}
