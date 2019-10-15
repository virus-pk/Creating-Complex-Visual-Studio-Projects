using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InfrastructureLayer.VO;
using InfrastructureLayer.Common;
using DataAccessLayer.DAO;

namespace UnitTests.DataAccessLayer.DAO
{
    /// <summary>
    /// Summary description for EmployeeDAOTests
    /// </summary>
    [TestClass]
    public class EmployeeDAOTests
    {
        public EmployeeDAOTests()
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

        [TestMethod]
        public void InsertEmployeeTest()
        {
            EmployeeVO2 vo = new EmployeeVO2();
            int originalID = vo.ID;
            EmployeeDAO dao = new EmployeeDAO();
            vo = dao.CreateEmployee(vo);

            Assert.AreNotEqual(originalID, vo.ID);

            dao.DeleteEmployee(vo.ID);
        }
    }
}
