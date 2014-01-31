using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LookingGlass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void takePictureButton_Click(object sender, EventArgs e)
        {
            PictureCapturer capturer = new PictureCapturer();
            capturer.capture(Int32.Parse(x0.Text), Int32.Parse(x1.Text), Int32.Parse(y0.Text), Int32.Parse(y1.Text), Int32.Parse(numPictures.Text));
        }

        private void fullScreenButton_Click(object sender, EventArgs e)
        {
            x0.Text = "0";
            x1.Text = Screen.PrimaryScreen.Bounds.Width + "";
            y0.Text = "0";
            y1.Text = Screen.PrimaryScreen.Bounds.Height + "";
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            PictureCapturer capturer = new PictureCapturer();
            capturer.drawSelectionBox(Int32.Parse(x0.Text), Int32.Parse(x1.Text), Int32.Parse(y0.Text), Int32.Parse(y1.Text));
        }
    }
}
