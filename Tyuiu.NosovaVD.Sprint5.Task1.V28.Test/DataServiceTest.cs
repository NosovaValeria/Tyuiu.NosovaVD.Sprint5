﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.NosovaVD.Sprint5.Task1.V28.Lib;

namespace Tyuiu.NosovaVD.Sprint5.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Валерия\source\repos\Tyuiu.NosovaVD.Sprint5\Tyuiu.NosovaVD.Sprint5.Task1.V28\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
