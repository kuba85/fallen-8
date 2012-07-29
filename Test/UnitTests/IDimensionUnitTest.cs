﻿#region Usings

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoSQL.GraphDB.Index.Spatial;

#endregion

namespace NoSQL.GraphDB.Test
{
    
    
    /// <summary>
    ///This is a test class for IDimensionUnitTest and is intended
    ///to contain all IDimensionUnitTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IDimensionUnitTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        internal virtual IDimension CreateIDimension()
        {
            // TODO: Instantiate an appropriate concrete class.
            IDimension target = null;
            return target;
        }

        /// <summary>
        ///A test for CountOfR
        ///</summary>
        [TestMethod()]
        public void CountOfRUnitTest()
        {
            Assert.Inconclusive("TODO");

            IDimension target = CreateIDimension(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CountOfR;
        }

        /// <summary>
        ///A test for ObjectType
        ///</summary>
        [TestMethod()]
        public void ObjectTypeUnitTest()
        {
            Assert.Inconclusive("TODO");

            IDimension target = CreateIDimension(); // TODO: Initialize to an appropriate value
            Type actual;
            actual = target.ObjectType;
        }
    }
}
