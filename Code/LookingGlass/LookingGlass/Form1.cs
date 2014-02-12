using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;




namespace LookingGlass
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(HandleRef hwnd, out RECT lpRect);

        public Form1()
        {
            InitializeComponent();
        }



        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
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

        private void getProcesses_Click(object sender, EventArgs e)
        {
            PictureCapturer capturer = new PictureCapturer();
            foreach (ProcessPair s in capturer.getProcesses())
                runningApps.Items.Add(s);
        }

        private void selectApplication_Click(object sender, EventArgs e)
        {
            ProcessPair selected = (ProcessPair)runningApps.Items[runningApps.SelectedIndex];
            RECT rectangle;
            GetWindowRect(new HandleRef(this, selected.handle), out rectangle);
            x0.Text = rectangle.Left.ToString();
            x1.Text = rectangle.Right.ToString();
            y0.Text = rectangle.Top.ToString();
            y1.Text = rectangle.Bottom.ToString();
        }
    }
}
