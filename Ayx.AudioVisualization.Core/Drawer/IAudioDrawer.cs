using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace Ayx.AudioVisualization.Core
{
    public interface IAudioDrawer
    {
        Bitmap GetBitmap();
        ImageSource GetImageSource();
    }
}
