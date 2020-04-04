using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ayx.AudioVisualization.Core
{
    public class AudioInfo
    {
        public FormatInfo FormatInfo { get; private set; }
        public float[] SingleChannel { get; private set; }
        public float[] LeftChannel { get; private set; }
        public float[] RightChannel { get; private set; }

        public AudioInfo(FormatInfo info, float[] single)
        {
            FormatInfo = info;
            SingleChannel = single;
        }

        public AudioInfo(FormatInfo info, float[] left, float[] right)
        {
            FormatInfo = info;
            LeftChannel = left;
            RightChannel = right;
        }
    }
}
