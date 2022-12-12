using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profit_Calculator
{
    public partial class CustomMessageBox : Form
    {
        private bool mouseDown;
        private Point offSet;
        public CustomMessageBox(string message)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            labelMessage.Text = message;
            Opacity = 0.9;
        }

        private void buttonOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomMessageBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void CustomMessageBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offSet.X, currentScreenPos.Y - offSet.Y);
            }
        }

        private void CustomMessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            offSet.X = e.X;
            offSet.Y = e.Y;
            mouseDown = true;
        }
    }
}
