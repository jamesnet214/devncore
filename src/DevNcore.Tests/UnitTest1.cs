using DevNcore.UI.Design.Geometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevNcore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var data = GeometryPack.Find("AccountArrowLeftOutline");

            Console.WriteLine(data);
        }
    }
}