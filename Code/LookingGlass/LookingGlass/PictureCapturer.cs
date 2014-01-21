using System;
using System.Drawing;
using System.Windows.Forms;

public class PictureCapturer
{
    

	public PictureCapturer()
	{
	}

    public void capture(int x0, int x1, int y0, int y1, int toCapture)
    {
        Bitmap screenCap = new Bitmap(x1-x0, y1-y0);
        Graphics graphics = Graphics.FromImage(screenCap);
        int numCaptures = 0;
        while (numCaptures < toCapture)
        {
            graphics.CopyFromScreen(x0, y0, 0, 0, new Size(x1 - x0, y1 - y0));
            screenCap.Save("C://" + DateTime.Now.Millisecond + ".bmp");
            numCaptures++;
        }
    }
}
