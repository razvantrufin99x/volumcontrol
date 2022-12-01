using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace volumcontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int startx;
        public int starty;
        public int length;
        public int ismousedown = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            startx = dragablebar1.Left;
            starty = dragablebar1.Top;
            length = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dragablebar1.Top != starty) { dragablebar1.Top = starty; }
            if (dragablebar1.Left < startx) { dragablebar1.Left = startx; }
            if (dragablebar1.Left > (startx + length)) { dragablebar1.Left =( startx + length); }
        }

        private void pixelcontrol2_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void pixelcontrol3_MouseUp(object sender, MouseEventArgs e)
        {
            ismousedown = 0;
        }

        private void pixelcontrol3_MouseDown(object sender, MouseEventArgs e)
        {
            ismousedown = 1;
        }

        private void pixelcontrol3_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismousedown == 1)
            {
                Left += e.X;
                Top += e.Y;
            }
        }

       
    }
}
