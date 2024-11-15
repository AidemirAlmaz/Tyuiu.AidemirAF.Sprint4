using Tyuiu.AidemirAF.Sprint4.Task0.V13.Lib;

namespace Tyuiu.AidemirAF.Sprint4.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 0, 1, 2, 3 };
            int res = ds.GetSumEvenArrEl(numsArray);
            int numsWait = 2;
            Assert.AreEqual(numsWait, res);
        }
    }
}