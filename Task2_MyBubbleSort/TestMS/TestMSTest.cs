using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMSTest
{
    [TestClass]
    public class ArraySortTestsDDT
    {
        private TestContext testContextInstance;
        public abstract System.Data.DataRow DataRow { get; }
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]
        public void TestMethod1()
        {
            
            int a = int.Parse(TestContext.DataRow["number1"].ToString());
        }


    }
}
