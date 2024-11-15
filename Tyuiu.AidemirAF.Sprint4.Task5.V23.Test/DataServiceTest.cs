using Tyuiu.AidemirAF.Sprint4.Task5.V23.Lib;

namespace Tyuiu.AidemirAF.Sprint4.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[2, 2] 
            {
            {-1, 1},
            {-2, 2}
            };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = { { 0, 1 }, { 0, 2 } };
            CollectionAssert.AreEqual(wait, res);

        }
    }
}