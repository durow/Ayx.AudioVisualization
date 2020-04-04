using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ayx.AudioVisualization.Core
{
    public class FormatInfo
    {
        public long SampleNumber { get; protected set; }
        public int SampleBit { get; protected set; }
        public int TotalSeconds { get; protected set; }
        public int FormatCode { get; protected set; }
        public int Channels { get; protected set; }
        public int SampleRate { get; protected set; }
    }
}
