using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ayx.AudioVisualization.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ayx.AudioVisualization.Core.Tests
{
    [TestClass()]
    public class PeakInfoTests
    {
        [TestMethod()]
        public void PeakInfoTestEmpty()
        {
            var data = GetTestData(200);
            var info = new PeakInfo(data, 10, 0);
            Assert.AreEqual(0, info.Max);
            Assert.AreEqual(0, info.Min);
        }

        [TestMethod()]
        public void PeakInfoTestOne()
        {
            var data = GetTestData(200);
            var info = new PeakInfo(data, 101, 1);
            Assert.AreEqual(data[101], info.Max);
            Assert.AreEqual(data[101], info.Min);
        }

        [TestMethod()]
        public void PeakInfoTest()
        {
            var data = GetTestData(200);
            var info = new PeakInfo(data, 50, 20);
            var buff = new float[20];
            Array.Copy(data, 50, buff, 0, 20);
            Assert.AreEqual(buff.Max(), info.Max);
            Assert.AreEqual(buff.Min(), info.Min);
        }

        private float[] GetTestData(int count)
        {
            var data = new float[count];
            var rand = new Random();
            for (int i = 0; i < count; i++)
            {
                data[i] = (float)rand.NextDouble();
            }
            return data;
        }
    }
}