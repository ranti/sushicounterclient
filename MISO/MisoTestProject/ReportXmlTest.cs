﻿using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SushiLibrary;

namespace MisoTestProject
{
    /// <summary>
    /// Summary description for ReportXmlTest
    /// </summary>
    [TestClass]
    public class ReportXmlTest
    {
        private XmlDocument JR1SampleReport;

        public ReportXmlTest()
        {
            FileStream JR1SampleFile = new FileStream("D:\\sushicounterclient\\MISO\\MISO\\JR1v3SampleData.xml", FileMode.Open, FileAccess.Read);
            JR1SampleReport = new XmlDocument();
            JR1SampleReport.Load(JR1SampleFile);

            JR1SampleFile.Close();
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestLoadingReport()
        {
            ReportLoader.LoadCounterReport(JR1SampleReport);
        }
    }
}
