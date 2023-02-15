using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FictumAnalog
{
    public partial class Form1 : Form
    {
        public int counter = 0; 
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        void Timer1Tick(object sender, EventArgs e)
        {
            counter++;
            DrawViaRotate();

        }
        public void DrawViaRotate()
        {
            var g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            g.TranslateTransform(100, 100);
            g.RotateTransform(6 * counter);
            g.DrawLine(pen, 0, 0, 90, 0);
            g.ResetTransform();
        }
    }
}
