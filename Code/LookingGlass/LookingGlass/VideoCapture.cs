using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LookingGlass
{
    class VideoCapture
    {
        PictureCapturer picCapturer;

        public VideoCapture()
        {
            picCapturer = new PictureCapturer();
        }
    }
}
