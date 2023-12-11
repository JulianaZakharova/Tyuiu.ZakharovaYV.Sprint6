using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZakharovaYV.Sprint6.Task6.V9.Lib;
using System.IO;

namespace Tyuiu.ZakharovaYV.Sprint6.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ExistsFile()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V9.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService DataService = new DataService();

            string path = @"C:\DataSprint6\InPutFileTask6V9.txt";
            string res = "DvbkNN MPO GEzUiEPbamDblZ jKVWBlKg QzObVnRejHHXCeP ";
            string str = DataService.CollectTextFromFile(res, path);
            Assert.AreEqual(str, res);

        }
    }
}