using System;

public class PictureCapturer
{
    

	public PictureCapturer()
	{
	}

    public Bitmap capture(int x0, int x1, int y0, int y1)
    {
        Bitmap screenCap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        //Graphics graphics = Graphics.FromImage(screenCap);
        //graphics.CopyFromScreen();
        //graphics.
        screenCap.Save(System.DateTime);
    }
}
