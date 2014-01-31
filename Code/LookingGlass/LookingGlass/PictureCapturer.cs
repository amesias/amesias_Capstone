using System;
using System.Drawing;
using System.Windows.Forms;

public class PictureCapturer
{
    Form selectionForm;

	public PictureCapturer()
	{
	}

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

    public void capture(int x0, int x1, int y0, int y1, int toCapture)
    {
        Bitmap screenCap = new Bitmap(x1-x0, y1-y0);
        Graphics graphics = Graphics.FromImage(screenCap);
        int numCaptures = 0;
        while (numCaptures < toCapture)
        {
            graphics.CopyFromScreen(x0, y0, 0, 0, new Size(x1 - x0, y1 - y0));
            screenCap.Save("C://" + numCaptures + "_" + DateTime.Now.Millisecond + ".bmp");
            System.Threading.Thread.Sleep(1000 / 25);
            numCaptures++;
        }
    }
}
