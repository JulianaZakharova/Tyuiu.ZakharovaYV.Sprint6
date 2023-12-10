using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZakharovaYV.Sprint6.Task5.V12.Lib;

namespace Tyuiu.ZakharovaYV.Sprint6.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\USER\source\repos\Tyuiu.ZakharovaYV.Sprint6\Tyuiu.ZakharovaYV.Sprint6.Task5.V12\bin\Debug\InPutFileTask5V12.txt";
            DataService ds = new DataService();
            double[] res = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(res, new double[] { 5.0 });
        }
    }
}
