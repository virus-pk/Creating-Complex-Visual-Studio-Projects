using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InfrastructureLayer.VO;

namespace UnitTests.InfrastructureLayer.VO
{
    /// <summary>
    /// Summary description for EmployeeVO2Test
    /// </summary>
    [TestClass]
    public class EmployeeVO2Test
    {
        public EmployeeVO2Test()
        {
            //
            // TODO: Add constructor logic here
            //
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

        public List<string> StringList { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            StringList = new List<string>();

            StringList.Add("Hello");
            StringList.Add("World");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsNotNull(StringList);
            Assert.AreEqual(2, StringList.Count);
        }

        [TestMethod]
        public void EmpVOConstTest()
        {
            //Arrange
            EmployeeVO2 e1 = new EmployeeVO2();
            EmployeeVO2 e2 = new EmployeeVO2();

            //Act
            e2.FirstName = "Rick";

            //Assert
            Assert.IsNotNull(e1);
            Assert.IsNotNull(e2);
            Assert.IsNotNull(e1.FirstName);
            Assert.IsNotNull(e1.MiddleName);
            Assert.IsNotNull(e1.LastName);
            Assert.AreNotEqual(e1.FirstName, e2.FirstName);

        }

    }
}
