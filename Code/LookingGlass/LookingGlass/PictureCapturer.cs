using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Diagnostics;

public class PictureCapturer
{
    Form selectionForm;

	public PictureCapturer()
	{
	}

    struct PointApi
    {
        public int x;
        public int y;
    }

    struct CursorInfo
    {
        public Int32 cbSize;
        public Int32 flags;
        public IntPtr hCursor;
        public PointApi pointScreenPosition;
    }

    [DllImport("user32.dll")]
    static extern bool GetCursorInfo(out CursorInfo pci);

    [DllImport("user32.dll")]
    static extern bool DrawIcon(IntPtr hDC, int X, int Y, IntPtr hIcon);

    const Int32 CURSOR_VISIBLE = 0x00000001;

    public void drawSelectionBox(int x0, int x1, int y0, int y1)
    {
        selectionForm = new Form();
        selectionForm.FormBorderStyle = FormBorderStyle.None;
        selectionForm.Opacity = .50;
        selectionForm.Height = y1 - y0;
        selectionForm.Width = x1 - x0;
        selectionForm.WindowState = FormWindowState.Normal;
        selectionForm.StartPosition = FormStartPosition.Manual;
        selectionForm.Location = new Point(x0, y0);
        selectionForm.Visible = true;

        System.Threading.Thread.Sleep(1000);
        hideSelectionBox();
    }

    private void hideSelectionBox()
    {
        selectionForm.Close();
        selectionForm = null;
    }

    public List<String> getProcesses()
    {
        List<String> results = new List<String>();
        Process[] processes = Process.GetProcesses();
        for (int i = 0; i < processes.Length; i++)
            results.Add(processes[i].ProcessName);
        Console.WriteLine(processes[0].MainWindowHandle);
        return results;
    }

    public void capture(int x0, int x1, int y0, int y1, int toCapture)
    {
        Bitmap screenCap = new Bitmap(x1 - x0, y1 - y0);
        Graphics graphics = Graphics.FromImage(screenCap);
        int numCaptures = 0;
        long started = DateTime.Now.ToBinary();
        while (numCaptures < toCapture)
        {
            graphics.CopyFromScreen(x0, y0, 0, 0, new Size(x1 - x0, y1 - y0));
            CursorInfo pci;
            pci.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(typeof(CursorInfo));
            GetCursorInfo(out pci);
            if (pci.flags == CURSOR_VISIBLE)
            {
                DrawIcon(graphics.GetHdc(), pci.pointScreenPosition.x, pci.pointScreenPosition.y, pci.hCursor);
                graphics.ReleaseHdc();
            }
            screenCap.Save("C://" + numCaptures + "_" + (DateTime.Now.ToBinary() - started) + ".bmp");
            System.Threading.Thread.Sleep(1000 / 25);
            numCaptures++;
        }
    }
}
