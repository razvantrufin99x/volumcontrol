using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace volumcontrol
{
    public partial class dragablebar : UserControl
    {
        public dragablebar()
        {
            InitializeComponent();
        }
        public int ismousedown = 0;

        private void dragablebar_MouseUp(object sender, MouseEventArgs e)
        {
            ismousedown = 0;
        }

        private void dragablebar_MouseDown(object sender, MouseEventArgs e)
        {
            ismousedown = 1;
        }

        private void dragablebar_MouseMove(object sender, MouseEventArgs e)
        {
            if(ismousedown == 1)
            {
                Left += e.X;
                //Top  += e.Y;
            }
        }
    }
}
