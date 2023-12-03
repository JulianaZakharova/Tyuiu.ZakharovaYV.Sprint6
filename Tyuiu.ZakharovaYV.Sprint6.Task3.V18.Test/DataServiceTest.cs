﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZakharovaYV.Sprint6.Task3.V18.Lib;

namespace Tyuiu.ZakharovaYV.Sprint6.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] numsmus2 = new int[5, 5] { {-19, -19, 1, 18, 7},
                                              {5, 3, -4, -6, -12},
                                              {-15, 6, 2, 2, -14},
                                              {-9, -10, 15, -5, -6},
                                              {-13, -15, -9, 7, 1} };
            int[,] res = ds.Calculate(numsmus2);

            int[,] numsWaitmus2 =   { {-19, -19, 1, 18, 7},
                                      {5, 3, -4, -6, -12},
                                      {-15, 6, 2, 2, -14},
                                      {-9, 0, 15, -5, 0},
                                      {-13, -15, -9, 7, 1} };



            CollectionAssert.AreEqual(numsWaitmus2, res);
        }
    }
}
