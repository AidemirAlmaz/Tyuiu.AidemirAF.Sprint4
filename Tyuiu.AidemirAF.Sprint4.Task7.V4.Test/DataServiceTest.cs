using Tyuiu.AidemirAF.Sprint4.Task7.V4.Lib;

namespace Tyuiu.AidemirAF.Sprint4.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int rows = 2;
            int columns = 2;
            int[,] matrix = new int[rows, columns];
            string str = "1020";
            int res = ds.Calculate(rows, columns, str);
            int wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}