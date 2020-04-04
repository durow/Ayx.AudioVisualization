/*
 * Description:Compute the peak of wave per pixel.
 * Author:durow
 * Date:2020.04.04
 */

namespace Ayx.AudioVisualization.Core
{
    public class PeakInfo
    {
        public float Max { get; private set; } = 0;
        public float Min { get; private set; } = 0;

        public PeakInfo(float[] data, int start, int len)
        {
            if (len == 0)
                return;

            if(len == 1)
            {
                Max = data[start];
                Min = data[start];
                return;
            }

            var one = data[start];
            var two = data[start + 1];
            if(one > two)
            {
                Max = one;
                Min = two;
            }
            else
            {
                Max = two;
                Min = one;
            }
            for (int i = 2; i < len; i++)
            {
                if (data[start + i] > Max)
                    Max = data[start + i];
                if (data[start + i] < Min)
                    Min = data[start + i];
            }
        }
    }
}
